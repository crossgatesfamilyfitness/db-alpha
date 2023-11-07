using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Ticket
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    public uint? StaffId { get; set; }

    public uint AddedBy { get; set; }

    public string Racquet { get; set; } = null!;

    public float Count { get; set; }

    public string String { get; set; } = null!;

    public string Tension { get; set; } = null!;

    /// <summary>
    /// day required
    /// </summary>
    public DateTime? DateTime { get; set; }

    public string Repairs { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? StaffComment { get; set; }

    public string? Report { get; set; }

    public bool Blocked { get; set; }

    public DateOnly BlockedDate { get; set; }

    public DateTime BlockedTime { get; set; }

    public DateTime? DropDate { get; set; }

    public string RepairNew { get; set; } = null!;

    public DateTime? CompleteDate { get; set; }

    public int InitialUser { get; set; }

    public int InitialStaff { get; set; }

    public sbyte HasHouseCharge { get; set; }

    public string? StaffRates { get; set; }

    public float StaffPayroll { get; set; }

    public string? ChargeIds { get; set; }

    public int EntityId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
