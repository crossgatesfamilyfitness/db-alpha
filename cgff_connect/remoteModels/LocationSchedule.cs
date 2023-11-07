using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LocationSchedule
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public int? AreaId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public bool? Active { get; set; }

    public TimeOnly? TimeFromDefault { get; set; }

    public TimeOnly? TimeToDefault { get; set; }

    public virtual LocationArea? Area { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual ICollection<LocationScheduleDay> LocationScheduleDays { get; } = new List<LocationScheduleDay>();
}
