using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GuestPassPackage
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public string Name { get; set; } = null!;

    public uint AddedBy { get; set; }

    public DateOnly AddedDate { get; set; }

    public DateOnly ActivatedDate { get; set; }

    public DateTime AddedTime { get; set; }

    public decimal PriceInitial { get; set; }

    public decimal Count { get; set; }

    public decimal CountInitial { get; set; }

    public sbyte Status { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public DateOnly UsedDate { get; set; }

    public string? Description { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public DateOnly StartDate { get; set; }

    public int AccGroupId { get; set; }

    public bool Family { get; set; }

    public string RuleId { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
