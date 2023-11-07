using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceSchedule
{
    public ulong Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public string ScheduleType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public TimeOnly? TimeFromDefault { get; set; }

    public TimeOnly? TimeToDefault { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<ServiceScheduleDay> ServiceScheduleDays { get; } = new List<ServiceScheduleDay>();

    public virtual ServiceType? ServiceType { get; set; }
}
