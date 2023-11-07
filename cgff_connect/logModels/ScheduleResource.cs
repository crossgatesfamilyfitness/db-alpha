using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class ScheduleResource
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

    public ulong ScheduleId { get; set; }

    public uint ResourceId { get; set; }

    public string? LogTransactionId { get; set; }
}
