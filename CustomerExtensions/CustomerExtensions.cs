using System;
using System.Collections.Generic;

$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;using TeqTank.Application.Mako;
$endif$using System.Text;

namespace $rootnamespace$
{
	public static class $safeitemrootname$
    {
        public static bool IsCustomer(this Customer c)
        {
            if (c.CustomerType == CustomerTypes.DirectMember ||
                c.CustomerType == CustomerTypes.PreferredMember ||
                c.CustomerType == CustomerTypes.Hostess) return true;

            return false;
        }

        public static bool IsDirectCustomer(this Customer c)
        {
            if (c.CustomerType == CustomerTypes.DirectMember ||
                c.CustomerType == CustomerTypes.DirectMember) return true;

            return false;
        }

        public static bool IsPreferredCustomer(this Customer c)
        {
            if (c.CustomerType == CustomerTypes.PreferredMember ||
                c.CustomerType == CustomerTypes.PreferredMember) return true;

            return false;
        }

        public static bool IsHostess(this Customer c)
        {
            if (c.CustomerType == CustomerTypes.Hostess ||
                c.CustomerType == CustomerTypes.Hostess) return true;

            return false;
        }

        public static bool IsDistributor(this Customer c)
        {
            if (c.CustomerType == CustomerTypes.MarketingConsultant ||
                c.CustomerType == CustomerTypes.MarketingConsultant) return true;

            return false;
        }

        public static bool IsCommissionable(this Customer c)
        {
            if (c.CustomerStatusType == CustomerStatusTypes.ACT ||
                c.CustomerStatusType == CustomerStatusTypes.SUSP) return true;

            return false;
        }

        public static bool IsOverrideTrue(this Customer c,int Override, MakoPlan Plan, MakoDataSource DataSource)
        {
            if (DataSource.Overrides.IsOverridden(Override, c.CustomerID))
                return true;

            return false;
        }

        public static decimal GetOverrideAmount(this Customer c, int Override, MakoPlan Plan, MakoDataSource DataSource)
        {
            decimal amt = 0M;
            if (DataSource.Overrides.IsOverridden(Override, c.CustomerID))
            {
                amt = DataSource.Overrides.GetValue(c, Override);
            }
            return amt;
        }

        public static void ClearVolume(this Customer c, VolumeBucket VolumeBucket, MakoResults Results)
        {
            Results.UpdateVolume(c, VolumeBucket, c.Volume(VolumeBucket) * -1);
        }

        public static Customer FindFirstUplineDistributorEnroller(this Customer c)
        {
            Customer PaidTo = c;
            while (PaidTo != null && !PaidTo.IsDistributor() && PaidTo.IsInTree(Trees.Enroller))
                PaidTo = PaidTo.TreeNode(Trees.Enroller).Parent.Customer;

            return PaidTo;
        }
    }
}