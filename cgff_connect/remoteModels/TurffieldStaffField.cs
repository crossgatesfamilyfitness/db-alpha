using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TurffieldStaffField
{
    public uint UserId { get; set; }

    public bool UseDefaultRates { get; set; }

    public string CalculateCourtFeeAs { get; set; } = null!;

    public string StaffLevel { get; set; } = null!;

    public string? PayrollType { get; set; }

    public string? CourtFeeArr { get; set; }

    public string? SummerCourtFeeArr { get; set; }

    public string? PlessonRates { get; set; }

    public string? SummerPlessonRates { get; set; }

    public string? PlessonPercentages { get; set; }

    public string? SummerPlessonPercentages { get; set; }

    public float? GroupLessonFee { get; set; }

    public float GroupLessonSummerFee { get; set; }

    public float GroupLessonPercent { get; set; }

    public float GroupLessonSummerPercent { get; set; }

    public float DirectorFee { get; set; }

    public float DirectorSummerFee { get; set; }

    public float DirectorComBaseRate { get; set; }

    public float DirectorComBaseSummerRate { get; set; }

    public string? GroupEventFees { get; set; }

    public sbyte PackageDiscountType { get; set; }

    public string? PackageLessonPriceData { get; set; }
}
