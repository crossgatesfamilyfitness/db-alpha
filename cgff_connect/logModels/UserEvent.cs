using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class UserEvent
{
    public ulong Id { get; set; }

    public string Type { get; set; } = null!;

    public string UpdatedColumns { get; set; } = null!;

    public string OldValues { get; set; } = null!;

    public string NewValues { get; set; } = null!;

    public int? UserId { get; set; }

    public uint? EventId { get; set; }

    public float CustomPrice { get; set; }

    public string CustomPriceType { get; set; } = null!;

    public float CustomPercent { get; set; }

    public bool IsMakeup { get; set; }

    public bool Prorate { get; set; }

    public DateOnly RegDate { get; set; }

    public float EventTotalCharge { get; set; }

    public float EventTotalPaid { get; set; }

    public string? LogTransactionId { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string Track { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
