using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventCloneHistory
{
    public uint Id { get; set; }

    public int EventId { get; set; }

    public int ClonedBy { get; set; }

    public DateTime ClonedAt { get; set; }
}
