using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceCommission
{
    public ulong Id { get; set; }

    public int? ServiceId { get; set; }

    public int? EntityId { get; set; }

    public int? StaffLevelId { get; set; }

    public int? StaffId { get; set; }

    public string CommissionType { get; set; } = null!;

    public int NumParticipants { get; set; }

    public decimal? Rate { get; set; }

    public string? CommissionBasis { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual Service? Service { get; set; }

    public virtual StaffLevel? StaffLevel { get; set; }
}
