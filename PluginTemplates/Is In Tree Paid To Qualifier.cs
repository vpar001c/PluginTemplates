using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsInEnrollerTree : PaidToQualifier
    {
        public override string Descr()
        {
            return string.Format("Customer must be in the Enroller Tree");
        }

        public override bool Qualified(PaidToArgs e)
        {
            return e.PaidTo.IsInTree(Trees.Enroller);
        }
    }
    
    public class IsInUnilevelTree : PaidToQualifier
    {
	public override string Descr()
	{
		return string.Format("Customer must be in the Unilevel Tree");
	}
	public override bool Qualified(PaidToArgs e)
	{
		return e.PaidTo.IsInTree(Trees.Unilevel);
	}
    }
    
    public class IsInMatrixTree : PaidToQualifier
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

    public class IsInBinaryTree : PaidToQualifier
    {
	public override string Descr()
	{
		return string.Format("Customer must be in the BinaryTree");
	}
	public override bool Qualified(PaidToArgs e)
	{
		return e.PaidTo.IsInTree(Trees.Binary);
	}
    }
}
