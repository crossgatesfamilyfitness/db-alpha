using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CheckinLocation
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int EntityId { get; set; }

    public bool? Status { get; set; }

    public bool System { get; set; }

    public bool? IncludeInCapacityCount { get; set; }

    public string Position { get; set; } = null!;

    public string? Params { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public int? ExternalId { get; set; }
}
