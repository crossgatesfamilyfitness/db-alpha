using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupEntityDiscount
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? EntityId { get; set; }

    public int? AccountingGroupId { get; set; }

    public decimal Amount { get; set; }

    public string Type { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
