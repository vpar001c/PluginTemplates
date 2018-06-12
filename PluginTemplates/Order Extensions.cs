using System;
using System.Collections.Generic;
using System.Text;
using TeqTank.Applications.Mako;

namespace FinalMakoTestPlan
{
    public static class OrderExtensions
    {
        public static bool IsAutoOrder(this Order o)
        {
            if (o.OrderTy == 4 || o.OrderTy == 9) return true;

            return false;
        }
	public static bool IsOther1Order(this Order o)
        {
            if (o.OtherValue1 == 1) return true;

            return false;
        }
	public static bool IsOther2Order(this Order o)
        {
            if (o.OtherValue2 == 1) return true;

            return false;
        }
	public static bool IsOther3Order(this Order o)
        {
            if (o.OtherValue3 == 1) return true;

            return false;
        }
	public static bool IsOther4Order(this Order o)
        {
            if (o.OtherValue4 == 1) return true;

            return false;
        }
	public static bool IsOther5Order(this Order o)
        {
            if (o.OtherValue5 == 1) return true;

            return false;
        }
	public static bool IsOther6Order(this Order o)
        {
            if (o.OtherValue6 == 1) return true;

            return false;
        }
	public static bool IsOther7Order(this Order o)
        {
            if (o.OtherValue7 == 1) return true;

            return false;
        }
	public static bool IsOther8Order(this Order o)
        {
            if (o.OtherValue8 == 1) return true;

            return false;
        }
	public static bool IsOther9Order(this Order o)
        {
            if (o.OtherValue9 == 1) return true;

            return false;
        }
        public static bool IsOther10Order(this Order o)
        {
            if (o.OtherValue10 == 1) return true;

            return false;
        }

        public static bool IsRetailOrder(this Order o)
        {
            if (o.PriceTy == 1) return true;

            return false;
        }

        public static decimal GetBV(this Order o)
        {
            return o.QV;
        }

        public static decimal GetCV(this Order o)
        {
            return o.CV;
        }

    }
}
