using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GuestHash
{
    public uint Id { get; set; }

    public string Hash { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
