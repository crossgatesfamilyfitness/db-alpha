using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffScheduleTime
{
    public ulong Id { get; set; }

    public ulong? StaffScheduleId { get; set; }

    public TimeOnly? TimeFrom { get; set; }

    public TimeOnly? TimeTo { get; set; }

    public virtual StaffSchedule? StaffSchedule { get; set; }
}
