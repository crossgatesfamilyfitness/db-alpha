using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ResourceSchedule
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public int ComponentId { get; set; }

    public int ServiceId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public string Type { get; set; } = null!;

    public int? RecurrenceId { get; set; }

    public int? InfoId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
