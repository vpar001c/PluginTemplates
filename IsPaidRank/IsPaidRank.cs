using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;using TeqTank.Application.Mako;
$endif$using System.Text;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : PaidToQualifier
    {
        public decimal RankID { get; set; }

        public int Weight { get; set; }
       
        public override string Descr()
        {
            return string.Format($"Paid at the Rank of {RankID} or Higher");
        }

        public override bool Qualified(PaidToArgs e)
        {
            return e.PaidTo.GetPaidRank(RankGroups.Primary) >= RankID;
        }

        public override string ActualValue(PaidToArgs e)
        {
            return e.PaidTo.GetPaidRank(RankGroups.Primary).ToString();
        }

        public override string RequiredValue(PaidToArgs e)
        {
            return RankID.ToString();
        }

        public override int ItemWeight(PaidToArgs e)
        {
            return Weight;
        }

        public override int ComputedWeight(PaidToArgs e)
        {
            if (Weight == 0) return 0;

            var result = Math.Ceiling((e.PaidTo.GetPaidRank(RankGroups.Primary) / RankID) * 100);
            if (result >= 100)
                return Weight;
            else if (result > 0)
                return Convert.ToInt32(Math.Ceiling(Weight * (result * .01M)));
            else
                return 0;
        }
    }
}
