using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Receipt
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? ParamsJson { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public int PosId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
