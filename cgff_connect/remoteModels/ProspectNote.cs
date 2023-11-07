using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ProspectNote
{
    public uint Id { get; set; }

    public uint ProspectId { get; set; }

    public uint AssignedToId { get; set; }

    public string Description { get; set; } = null!;

    public bool ShowAtCheckin { get; set; }

    public DateTime? Timestamp { get; set; }
}
