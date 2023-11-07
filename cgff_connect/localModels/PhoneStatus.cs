using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class PhoneStatus
{
    public int Id { get; set; }

    public string NumberDigits { get; set; } = null!;

    public bool? Status { get; set; }

    public int LastUpdatedAtUserId { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public DateTime? LastOptinDate { get; set; }
}
