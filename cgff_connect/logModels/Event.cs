using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class Event
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

    public uint ComponentId { get; set; }

    public uint AccGroupId { get; set; }

    public uint EventTypeId { get; set; }

    public uint ParentId { get; set; }

    public uint GroupId { get; set; }

    public string? LogTransactionId { get; set; }
}
