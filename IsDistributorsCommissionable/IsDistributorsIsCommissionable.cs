using System;
using System.Collections.Generic;
using TeqTank.Applications.Mako;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : PaidToQualifier
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


