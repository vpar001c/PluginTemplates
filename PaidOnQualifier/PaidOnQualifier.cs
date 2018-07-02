using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
using TeqTank.Application.Mako;
$endif$using System.Text;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : PaidOnQualifier
    {

	public override string Descr()
	{
		return base.Descr();
	}

	public override string ActualValue(PaidOnArgs e)
	{
 		return base.ActualValue(e);
	}


	public override string PercentComplete(PaidOnArgs e)
	{
 		return PercentComplete(e);
	}

	public override boolQualified(PaidOnArgs e)
	{
 		throw new NotImplementedException();
	}

	}
  }




