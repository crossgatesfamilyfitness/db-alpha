using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class Payroll
{
    public ulong Id { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public uint ModifiedBy { get; set; }

    public string Track { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public string UpdatedColumns { get; set; } = null!;

    public string OldValues { get; set; } = null!;

    public string NewValues { get; set; } = null!;

    public uint PayrollId { get; set; }

    public ulong StaffId { get; set; }

    public ulong EventId { get; set; }

    public DateOnly? Date { get; set; }

    public string PayrollType { get; set; } = null!;

    public string? LogTransactionId { get; set; }
}
