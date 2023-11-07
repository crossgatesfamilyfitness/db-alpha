using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class GroupEntityAccess
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

    public uint GroupEntityAccessId { get; set; }

    public uint GroupId { get; set; }
}
