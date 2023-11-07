using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleResource
{
    public ulong ScheduleId { get; set; }

    public int ResourceId { get; set; }

    public uint ModifiedBy { get; set; }

    public string LastTrack { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
