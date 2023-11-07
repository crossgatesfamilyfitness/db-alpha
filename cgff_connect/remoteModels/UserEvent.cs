using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserEvent
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public uint? PreviousEventId { get; set; }

    public uint? EventId { get; set; }

    public float CustomPrice { get; set; }

    public string CustomPriceType { get; set; } = null!;

    public float CustomPercent { get; set; }

    public float CustomTimes { get; set; }

    public string CustomNumber { get; set; } = null!;

    public float CalcPricePerHour { get; set; }

    public bool IsRemoved { get; set; }

    public bool IsMakeup { get; set; }

    public bool IsPerTime { get; set; }

    public bool IsCustom { get; set; }

    public bool Prorate { get; set; }

    public DateOnly ProrateDate { get; set; }

    public DateOnly RegDate { get; set; }

    public DateOnly UnregDate { get; set; }

    public float EventTotalCharge { get; set; }

    public float EventTotalPaid { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public string? Params { get; set; }

    public string WaiverSign { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
