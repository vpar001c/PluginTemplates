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
            return string.Format("Customer must be in the Enroller Tree");
        }

        public override bool Qualified(PaidOnArgs e)
        {
            return e.PaidOn.IsInTree(Trees.Enroller);
        }
    }

    public class IsInUnilevelTreePaidOn : PaidOnQualifier
    {
        public override string Descr()
        {
            return string.Format("Customer must be in the Unilevel Tree");
        }

        public override bool Qualified(PaidOnArgs e)
        {
            return e.PaidOn.IsInTree(Trees.Unilevel);
        }
    }

    public class IsInMatrixTreePaidOn : PaidOnQualifier
    {
        public override string Descr()
        {
            return string.Format("Customer must be in the Matrix Tree");
        }

        public override bool Qualified(PaidOnArgs e)
        {
            return e.PaidOn.IsInTree(Trees.Matrix);
        }
    }

    public class IsInBinaryTreePaidOn : PaidOnQualifier
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
