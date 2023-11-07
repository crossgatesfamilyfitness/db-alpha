using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Bundle
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool AvailableForSale { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
