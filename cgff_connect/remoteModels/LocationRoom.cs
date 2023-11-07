using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LocationRoom
{
    public int Id { get; set; }

    public int? AreaId { get; set; }

    public string Name { get; set; } = null!;

    public string Classification { get; set; } = null!;

    public bool AllowStations { get; set; }

    public string StationPrefix { get; set; } = null!;

    public int NumStations { get; set; }

    public int MaxParticipants { get; set; }

    public bool? IsAvailable { get; set; }

    public int SortOrder { get; set; }

    public bool? Active { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual LocationArea? Area { get; set; }

    public virtual ICollection<LocationStation> LocationStations { get; } = new List<LocationStation>();

    public virtual ICollection<ScheduleRoom> ScheduleRooms { get; } = new List<ScheduleRoom>();

    public virtual ICollection<ServiceLocation> ServiceLocations { get; } = new List<ServiceLocation>();
}
