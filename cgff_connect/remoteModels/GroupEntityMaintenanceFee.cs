using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupEntityMaintenanceFee
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? EntityId { get; set; }

    public string Type { get; set; } = null!;

    public short? CycleDuration { get; set; }

    public string? CycleType { get; set; }

    public short? DelayInterval { get; set; }

    public string? DelayIntervalType { get; set; }

    public short? BillDay { get; set; }

    public short? BillMonth { get; set; }

    public string StatementDescription { get; set; } = null!;

    public decimal Fee { get; set; }

    public int? AccountingGroupId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
