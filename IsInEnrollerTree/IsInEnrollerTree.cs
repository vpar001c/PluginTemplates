using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
using TeqTank.Application.Mako;
$endif$using System.Text;
using TeqTank.Applications.Mako;

namespace $rootnamespace$
{
	class $safeitemrootname$: PaidToQualifier
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
}
