using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Metric
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    /// <summary>
    /// is active
    /// </summary>
    public sbyte InUse { get; set; }

    public int Order { get; set; }

    public string? Params { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
