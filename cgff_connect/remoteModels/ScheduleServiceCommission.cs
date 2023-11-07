using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleServiceCommission
{
    public ulong Id { get; set; }

    public uint EventId { get; set; }

    public ulong ScheduleId { get; set; }

    public int StaffId { get; set; }

    public string CommissionBasis { get; set; } = null!;

    public string WhoPaysDiscount { get; set; } = null!;

    public bool LimitCommissionByRevenue { get; set; }

    public decimal Rate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public DateTime ModifiedDate { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
