using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ReservationStatus
{
    public ulong Id { get; set; }

    public uint EventId { get; set; }

    public ulong ScheduleId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public int ModifiedByIntranet { get; set; }

    public string? LastTrack { get; set; }

    public virtual Schedule Schedule { get; set; } = null!;
}
