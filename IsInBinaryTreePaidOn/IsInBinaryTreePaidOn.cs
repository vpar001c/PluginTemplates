using System;
using System.Collections.Generic;
using TeqTank.Application.Mako;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;using TeqTank.Application.Mako;
$endif$using System.Text;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : PaidOnQualifier
    {
        public override string Descr()
        {
            return string.Format("Customer must be in the Binary Tree");
        }

        public override bool Qualified(PaidOnArgs e)
        {
            return e.PaidOn.IsInTree(Trees.Binary);
        }
    }
}
