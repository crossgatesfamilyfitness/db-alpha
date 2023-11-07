using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleStatus
{
    public int Id { get; set; }

    public int ScheduleId { get; set; }

    public string Status { get; set; } = null!;
}
