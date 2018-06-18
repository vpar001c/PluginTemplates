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
