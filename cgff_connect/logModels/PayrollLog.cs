using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class PayrollLog
{
    public ulong Id { get; set; }

    public string? LogTransactionId { get; set; }

    public string Type { get; set; } = null!;

    public uint ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string UpdatedColumns { get; set; } = null!;

    public string OldValues { get; set; } = null!;

    public string NewValues { get; set; } = null!;

    public string Track { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public ulong PayrollLogId { get; set; }

    public uint StaffId { get; set; }

    public uint UserId { get; set; }

    public ulong EventId { get; set; }

    public ulong ScheduleId { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? ScheduleDate { get; set; }

    public sbyte? PayrollLogType { get; set; }

    public int? RowType { get; set; }

    public decimal? Amount { get; set; }

    public float? Duration { get; set; }
}
