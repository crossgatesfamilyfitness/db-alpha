using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleReserve
{
    public int Id { get; set; }

    public int ScheduleId { get; set; }

    public int ResourceId { get; set; }

    public int ResourceTypeId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
