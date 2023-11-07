using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleCopy
{
    public ulong Id { get; set; }

    public ulong ScheduleId { get; set; }

    public int ResourceId { get; set; }

    public ulong ScheduleCopy1 { get; set; }

    public int ResourceCopy { get; set; }
}
