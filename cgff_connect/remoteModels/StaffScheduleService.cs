using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffScheduleService
{
    public ulong Id { get; set; }

    public ulong? StaffScheduleId { get; set; }

    public int? ServiceTypeId { get; set; }

    public virtual ServiceType? ServiceType { get; set; }

    public virtual StaffSchedule? StaffSchedule { get; set; }
}
