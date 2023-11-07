using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GeneralDeclineFeeExcludedAchCode
{
    public int Id { get; set; }

    public string ScheduleType { get; set; } = null!;

    public bool? DayOfMonth { get; set; }

    public string GatewayType { get; set; } = null!;

    public string ExcludedCode { get; set; } = null!;
}
