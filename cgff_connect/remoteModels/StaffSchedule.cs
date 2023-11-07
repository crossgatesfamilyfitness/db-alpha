using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffSchedule
{
    public ulong Id { get; set; }

    public int? UserId { get; set; }

    public int? EntityId { get; set; }

    public int? ComponentId { get; set; }

    public DateOnly? Date { get; set; }

    public ulong? RepeatId { get; set; }

    public sbyte ConcurrentBookings { get; set; }

    public virtual Component? Component { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual ICollection<StaffSchedule> InverseRepeat { get; } = new List<StaffSchedule>();

    public virtual StaffSchedule? Repeat { get; set; }

    public virtual ICollection<StaffScheduleService> StaffScheduleServices { get; } = new List<StaffScheduleService>();

    public virtual ICollection<StaffScheduleTime> StaffScheduleTimes { get; } = new List<StaffScheduleTime>();
}
