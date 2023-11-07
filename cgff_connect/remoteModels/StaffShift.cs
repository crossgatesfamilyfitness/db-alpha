using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffShift
{
    public long Id { get; set; }

    public long StaffShiftScheduleId { get; set; }

    public DateTime DateTimeFrom { get; set; }

    public DateTime DateTimeTo { get; set; }

    public virtual StaffShiftSchedule StaffShiftSchedule { get; set; } = null!;
}
