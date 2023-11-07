using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleUserPackage
{
    public ulong Id { get; set; }

    public ulong ScheduleId { get; set; }

    public uint UserPackageId { get; set; }

    public int UserId { get; set; }
}
