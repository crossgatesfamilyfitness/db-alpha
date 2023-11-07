using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleRoom
{
    public int Id { get; set; }

    public ulong ScheduleId { get; set; }

    public int RoomId { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual LocationRoom Room { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
