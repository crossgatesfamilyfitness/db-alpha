using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceScheduleDay
{
    public ulong Id { get; set; }

    public ulong? ServiceScheduleId { get; set; }

    public string DayOfWeek { get; set; } = null!;

    public TimeOnly? TimeFrom { get; set; }

    public TimeOnly? TimeTo { get; set; }

    public virtual ServiceSchedule? ServiceSchedule { get; set; }
}
