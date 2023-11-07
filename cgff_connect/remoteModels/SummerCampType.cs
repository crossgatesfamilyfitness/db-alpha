using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SummerCampType
{
    public int Id { get; set; }

    public int SummerCampId { get; set; }

    public string Name { get; set; } = null!;

    public decimal? PriceBeforeDeadline { get; set; }

    public decimal? PriceAfterDeadline { get; set; }

    public string? Weekdays { get; set; }
}
