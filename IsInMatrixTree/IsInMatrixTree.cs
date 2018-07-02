using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;using TeqTank.Application.Mako;
$endif$using System.Text;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : PaidToQualifier
    {
        public override string Descr()
        {
            return string.Format("Customer must be in the MatrixTree");
        }
        public override bool Qualified(PaidToArgs e)
        {
            return e.PaidTo.IsInTree(Trees.Matrix);
        }
    }

}
