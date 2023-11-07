using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class Charge
{
    public ulong Id { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public DateOnly? ModifiedDateIndex { get; set; }

    public ulong ChargeId { get; set; }

    public uint ModifiedBy { get; set; }

    public string Track { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public int UserId { get; set; }

    public int AccountingGroupId { get; set; }

    public ulong SubjectId { get; set; }

    public ulong ScheduleId { get; set; }

    public ulong EventId { get; set; }

    public float PriceFinal { get; set; }

    public string Status { get; set; } = null!;

    public ulong EftId { get; set; }

    public string UpdatedColumns { get; set; } = null!;

    public string OldValues { get; set; } = null!;

    public string NewValues { get; set; } = null!;

    public string? LogTransactionId { get; set; }
}
