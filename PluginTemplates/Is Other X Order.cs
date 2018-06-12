using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther1Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 1");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther1Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther2Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 2");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther2Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther3Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 3");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther3Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther4Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 4");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther4Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther5Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 5");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther5Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther6Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 6");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther6Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther7Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 7");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther7Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther8Order : OrderQualifier
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

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther9Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 9");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther9Order()) return true;

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public class IsOther10Order : OrderQualifier
    {
        public override string Descr()
        {
            return string.Format("Order must have a value in Other Value 10");
        }

        public override bool Qualified(OrderArgs e)
        {
            if (e.Order.IsOther10Order()) return true;

            return false;
        }
    }
}
