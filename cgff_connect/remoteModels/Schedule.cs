using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Schedule
{
    public ulong Id { get; set; }

    public DateOnly Date { get; set; }

    public DateOnly PayrollDate { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public TimeOnly TimeBegin { get; set; }

    public TimeOnly? TimeEnd { get; set; }

    public int EventId { get; set; }

    public int ComponentId { get; set; }

    public int? AreaId { get; set; }

    public bool IsUsed { get; set; }

    public bool ForSale { get; set; }

    public bool Blocked { get; set; }

    public DateOnly BlockedDate { get; set; }

    public DateTime BlockedTime { get; set; }

    public string Status { get; set; } = null!;

    public bool? Confirmed { get; set; }

    public sbyte DoNotCharge { get; set; }

    public bool ChargeSold { get; set; }

    public bool ChargeMember { get; set; }

    public bool SoldForFree { get; set; }

    public bool IsPaidOff { get; set; }

    public string Comment { get; set; } = null!;

    public sbyte SelectedPro { get; set; }

    public bool AttendSaved { get; set; }

    public int LocationId { get; set; }

    public int DirectorId { get; set; }

    public decimal ComissionRate { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public sbyte BillGuestFee { get; set; }

    public sbyte BallMachine { get; set; }

    public float? BallMachineAmount { get; set; }

    public string? OffsiteAddress { get; set; }

    public string? SParams { get; set; }

    public DateTime CreatedDate { get; set; }

    public int LessonType { get; set; }

    public int? RecurrenceId { get; set; }

    public long TeeTimeId { get; set; }

    public bool Unavailable { get; set; }

    /// <summary>
    /// Whether the game was scheduled online.
    /// </summary>
    public bool IsOnline { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public sbyte IsSeria { get; set; }

    public bool SetupTimeIncluded { get; set; }

    public bool CleanupTimeIncluded { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual LocationArea? Area { get; set; }

    public virtual ICollection<ReservationStatus> ReservationStatuses { get; } = new List<ReservationStatus>();

    public virtual ICollection<ScheduleRoom> ScheduleRooms { get; } = new List<ScheduleRoom>();

    public virtual ICollection<ScheduleServiceCommission> ScheduleServiceCommissions { get; } = new List<ScheduleServiceCommission>();
}
