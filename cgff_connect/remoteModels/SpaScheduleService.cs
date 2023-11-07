using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaScheduleService
{
    public ulong Id { get; set; }

    public uint ScheduleId { get; set; }

    public uint ServiceId { get; set; }
}
