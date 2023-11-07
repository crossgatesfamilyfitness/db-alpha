using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LocationScheduleDay
{
    public int Id { get; set; }

    public int? LocationScheduleId { get; set; }

    public string DayOfWeek { get; set; } = null!;

    public TimeOnly? TimeFrom { get; set; }

    public TimeOnly? TimeTo { get; set; }

    public virtual LocationSchedule? LocationSchedule { get; set; }
}
