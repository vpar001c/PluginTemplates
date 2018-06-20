using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;


namespace $rootnamespace$
{
    public class $safeitemrootname$  : PaidToQualifier
    {
        //Here you can add in any properties that need to be passed in from the XML allowing you to reuse the class
        //with different values.
        //Example :    public int Amt { get; set; }
        //In the XML you would have
        //Example :    <Qual InitClass="[ClassName]"  Amt=20/>  Where the Value in Amt will populate the Amt Property in your class upon execution.

        /// <summary>
        /// This is the Description of the Requirement.  Example    return "Member Must Be Active";
        /// </summary>
        /// <returns></returns>
        public override string Descr()
{
    return base.Descr();
}

/// <summary>
/// Returns if the Member Achieved the particular Requirement.  Example :  return e.PaidTo.Volume(VolumeTypes.OV) >= 10;
/// </summary>
/// <param name="e"></param>
/// <returns></returns>
public override bool Qualified(PaidToArgs e)
{
    return base.Qualified(e);
}

/// <summary>
/// This shows the Actual Value that the Distributor Achieved.  Example : return string.Format("{0:0.00", e.PaidTo.Volume(VolumeTypes.OV));
/// </summary>
/// <param name="e"></param>
/// <returns></returns>
public override string ActualValue(PaidToArgs e)
{
    return base.ActualValue(e);
}

/// <summary>
/// This is the Actual Value that the member is required to meet.   Example return string.Format("{0:0.00", Amt);
/// </summary>
/// <param name="e"></param>
/// <returns></returns>
public override string RequiredValue(PaidToArgs e)
{
    return base.RequiredValue(e);
}

/// <summary>
/// This is the Percent of the ItemWeight that is achieved.  The Item weight could be 60%, but of that the 
/// member has only gotten 50% of the 60% goal accomplished.  This helps us obtain an overall score.
///     Example :
///     if (Weight == 0) return 0;
///     var result = Math.Ceiling((e.PaidTo.Volume(VolumeTypes.GV) / Amt) * 100);
///     if (result >= 100)
///        return Weight;
///     else if (result > 0)
///        return Convert.ToInt32(Math.Ceiling(Weight* (result* .01M)));
///     else
///        return 0;
/// </summary>
/// <param name="e"></param>
/// <returns></returns>
public override int ComputedWeight(PaidToArgs e)
{
    return base.ComputedWeight(e);
}

/// <summary>
/// This is the difficulty of reaching this goal compared to the others based on a 100% scale.
/// Example :  ItemWeight could be 60% for this particular goal. This is used in conjunction with the scorecard.
/// </summary>
/// <param name="e"></param>
/// <returns></returns>
public override int ItemWeight(PaidToArgs e)
{
    return base.ItemWeight(e);
}

/// <summary>
/// This allows us to show this entry on the ScoreCard.  It is always true, unless set to false.
/// There will be certain things that we do not want to show on the scorecard.
/// </summary>
/// <returns></returns>
public override bool ShowReportCard()
{
    return base.ShowReportCard();
}

/// <summary>
/// This identifies the Volume Bucket used for this qualification.  If we let the system know that the requirement is based off a particular 
/// volume bucket, then less data needs to be stored off, and the system can use volume records to determine the outcome.
/// </summary>
/// <returns></returns>
public override VolumeBucket VolumeBucketUsed()
{
    return base.VolumeBucketUsed();
}
}

