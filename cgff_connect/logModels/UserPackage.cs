using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class UserPackage
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

    public uint UpackageId { get; set; }

    public uint PackageId { get; set; }

    public uint ComponentId { get; set; }

    public uint UserId { get; set; }

    public uint StaffId { get; set; }

    public byte Status { get; set; }

    public float Count { get; set; }

    public string Name { get; set; } = null!;

    public string? LogTransactionId { get; set; }
}
