using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CaacDoor
{
    public int Id { get; set; }

    public int DoorId { get; set; }

    public string Title { get; set; } = null!;

    public string Settings { get; set; } = null!;

    public int EntityId { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public string DeviceId { get; set; } = null!;

    public int? CheckinLocationId { get; set; }

    public string Status { get; set; } = null!;

    public string ErrorMessage { get; set; } = null!;

    public string Provider { get; set; } = null!;

    public string? AuthToken { get; set; }
}
