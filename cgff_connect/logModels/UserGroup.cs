using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class UserGroup
{
    public ulong Id { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public uint ModifiedBy { get; set; }

    public string Track { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public int? UserGroupId { get; set; }

    public string UpdatedColumns { get; set; } = null!;

    public string OldValues { get; set; } = null!;

    public string NewValues { get; set; } = null!;

    public uint UserId { get; set; }

    public uint GroupId { get; set; }

    public DateOnly? NextBillDate { get; set; }

    public string UgStatus { get; set; } = null!;

    public string? LogTransactionId { get; set; }
}
