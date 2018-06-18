using System;
using System.Collections.Generic;
using TeqTank.Applications.Mako;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : PaidOnQualifier
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



	














