using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsDistributorPaidOn : PaidOnQualifier
    {
        public override string Descr()
        {
            return string.Format("Must be a valid Customer Type - Distributor");
        }

        public override bool Qualified(PaidOnArgs e)
        {
            return e.PaidOn.IsDistributor();
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
    public class IsCustomerPaidOn : PaidOnQualifier
    {
        public override string Descr()
        {
            return string.Format("Must be a valid Customer Type - Retail Customer/Preferred Customer");
        }

        public override bool Qualified(PaidOnArgs e)
        {
            return e.PaidOn.IsCustomer();
        }

	public override bool ShowReportCard()
        {
            return false;
        }
    }
}

	














