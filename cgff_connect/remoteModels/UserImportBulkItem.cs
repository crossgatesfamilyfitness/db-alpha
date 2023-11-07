using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserImportBulkItem
{
    public int Id { get; set; }

    public uint RowId { get; set; }

    public int BulkId { get; set; }

    public uint? UserId { get; set; }

    public string? ImportId { get; set; }

    public uint? SubscriptionId { get; set; }

    public string Status { get; set; } = null!;

    public string? UserStatus { get; set; }

    public string? Errors { get; set; }

    public string InputData { get; set; } = null!;

    public virtual UserImportBulk Bulk { get; set; } = null!;
}
