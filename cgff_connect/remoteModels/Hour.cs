using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Hour
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public int LocationId { get; set; }

    public int SeasonId { get; set; }

    public int ParentHourId { get; set; }

    public string HourType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly DateStart { get; set; }

    public DateOnly DateEnd { get; set; }

    public string Status { get; set; } = null!;

    public bool Inactive { get; set; }

    public string TimeFromMin { get; set; } = null!;

    public string TimeToMax { get; set; } = null!;

    public string WeekTimes { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }
}
