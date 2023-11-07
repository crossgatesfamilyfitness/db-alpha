using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ChildcareSchedule
{
    public uint Id { get; set; }

    public uint ScheduleId { get; set; }

    public string Status { get; set; } = null!;

    public uint? DropoffGuardianId { get; set; }

    public uint? PickupGuardianId { get; set; }

    public int? DropoffStaffId { get; set; }

    public int? PickupStaffId { get; set; }

    public DateTime? ReservationDatetime { get; set; }

    public TimeOnly? ReservationTimeIn { get; set; }

    public TimeOnly? ReservationTimeOut { get; set; }

    public int? ReservedBy { get; set; }

    public DateTime? CancellationDatetime { get; set; }

    public int? CancellationBy { get; set; }

    public bool OnlineReservation { get; set; }

    public int GuardianLocation { get; set; }

    public sbyte DependentLevel { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
