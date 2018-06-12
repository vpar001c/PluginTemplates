using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsDistributor : PaidToQualifier
    {
        public override string Descr()
        {
            return string.Format("Customer must be a valid Customer Type - Distributor");
        }

        public override bool Qualified(PaidToArgs e)
        {
            return e.PaidTo.IsDistributor();
        }
        public override bool ShowReportCard()
        {
            return false;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsCommissionable : PaidToQualifier
    {
        public override string Descr()
        {
            return string.Format("Customer must be valid Customer Status to earn Commissions");
        }

        public override bool Qualified(PaidToArgs e)
        {
            return e.PaidTo.IsCommissionable();
        }
        public override bool ShowReportCard()
        {
            return false;
        }
    }
}
