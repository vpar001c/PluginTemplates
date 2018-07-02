using System;
using System.Collections.Generic;

$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
using TeqTank.Application.Mako;
$endif$using System.Text;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : OrderQualifier
    {   
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 8");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther8Order()) return true;

            return false;
        }
    }
}

