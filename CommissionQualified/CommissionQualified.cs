using System;
using System.Collections.Generic;
using TeqTank.Applications.Mako;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $rootnamespace$
{
	public static class $safeitemrootname$: PaidToQualifier
    {
        public decimal RequiredAmount { get; set; }

public int Weight { get; set; }
public override string Descr()
{
    return string.Format($"{RequiredAmount} Personal Purchase Volume");
}

public override bool Qualified(PaidToArgs e)
{
    return e.PaidTo.Volume(VolumeTypes.PPV) >= RequiredAmount;
}

public override int ItemWeight(PaidToArgs e)
{
    return Weight;
}

public override int ComputedWeight(PaidToArgs e)
{
    if (Weight == 0) return 0;

    var result = Math.Ceiling((e.PaidTo.Volume(VolumeTypes.PPV) / RequiredAmount) * 100);
    if (result >= 100)
        return Weight;
    else if (result > 0)
        return Convert.ToInt32(Math.Ceiling(Weight * (result * .01M)));
    else
        return 0;
}

public override bool ShowReportCard()
{
    return base.ShowReportCard();
}

public override VolumeBucket VolumeBucketUsed()
{
    return base.VolumeBucketUsed();
}
}
}
