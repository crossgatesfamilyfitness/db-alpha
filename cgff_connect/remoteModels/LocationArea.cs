using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LocationArea
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public string Name { get; set; } = null!;

    public string Classification { get; set; } = null!;

    public bool? Active { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual ICollection<LocationRoom> LocationRooms { get; } = new List<LocationRoom>();

    public virtual ICollection<LocationSchedule> LocationSchedules { get; } = new List<LocationSchedule>();

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();

    public virtual ICollection<ServiceLocation> ServiceLocations { get; } = new List<ServiceLocation>();
}
