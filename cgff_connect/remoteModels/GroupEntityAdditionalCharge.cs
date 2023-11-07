using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupEntityAdditionalCharge
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? EntityId { get; set; }

    public int? AccountingGroupId { get; set; }

    public decimal Amount { get; set; }

    public string StatementDescription { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
