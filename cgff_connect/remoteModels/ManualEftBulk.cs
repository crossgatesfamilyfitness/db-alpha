using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ManualEftBulk
{
    public long Id { get; set; }

    public int CreatedBy { get; set; }

    public string? NotificationEmail { get; set; }

    public bool Status { get; set; }

    public DateOnly BalanceDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? CreatedByIntranetId { get; set; }
}
