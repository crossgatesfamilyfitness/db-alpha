using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleFee
{
    public int Id { get; set; }

    public long ScheduleId { get; set; }

    public long EventId { get; set; }

    public long ResourceId { get; set; }

    public DateOnly Date { get; set; }

    public int UserId { get; set; }

    public sbyte RowType { get; set; }

    public bool HasHouseCharge { get; set; }

    public bool WasFree { get; set; }

    public float Duration { get; set; }

    public float TotalPrice { get; set; }

    public float TotalPaid { get; set; }

    public float PriceBeforeBlocked { get; set; }

    public float PaidBeforeBlocked { get; set; }

    public float TotalReturned { get; set; }

    public float ReturnedBeforeBlocked { get; set; }

    public decimal TotalPriceNotax { get; set; }

    public decimal TotalPaidNotax { get; set; }

    public decimal TotalReturnedNotax { get; set; }

    public decimal PriceBeforeBlockedNotax { get; set; }

    public decimal PaidBeforeBlockedNotax { get; set; }

    public decimal ReturnedBeforeBlockedNotax { get; set; }

    public DateOnly TotalPaidDate { get; set; }

    public DateOnly TotalReturnedDate { get; set; }

    public string ChargeIds { get; set; } = null!;

    public int UserCnt { get; set; }

    public string? FeesArray { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public DateOnly DateAdded { get; set; }

    public DateTime TimeAdded { get; set; }

    public sbyte RowStatus { get; set; }

    public string Description { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
