using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaScheduleAddon
{
    public ulong Id { get; set; }

    public uint ScheduleId { get; set; }

    public uint AddonId { get; set; }
}
