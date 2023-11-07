using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffLevel
{
    public int Id { get; set; }

    public int? ComponentId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }

    public virtual Component? Component { get; set; }

    public virtual ICollection<ServiceCommission> ServiceCommissions { get; } = new List<ServiceCommission>();

    public virtual ICollection<ServiceFee> ServiceFees { get; } = new List<ServiceFee>();

    public virtual ICollection<StaffLevelUser> StaffLevelUsers { get; } = new List<StaffLevelUser>();
}
