using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class Schedule
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

    public uint EventId { get; set; }

    public ulong ScheduleId { get; set; }

    public DateOnly Date { get; set; }

    public string? LogTransactionId { get; set; }

    public TimeOnly TimeBegin { get; set; }

    public TimeOnly TimeEnd { get; set; }
}
