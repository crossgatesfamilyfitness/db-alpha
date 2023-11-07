using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackageEvent
{
    public int Id { get; set; }

    public uint UpackageId { get; set; }

    public ulong EventId { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
