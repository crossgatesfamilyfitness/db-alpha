using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Service
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SetupTime { get; set; }

    public int ServiceTime { get; set; }

    public int CleanupTime { get; set; }

    public bool? Active { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual ICollection<Event> Events { get; } = new List<Event>();

    public virtual ICollection<ServiceAlternateFee> ServiceAlternateFees { get; } = new List<ServiceAlternateFee>();

    public virtual ICollection<ServiceCommission> ServiceCommissions { get; } = new List<ServiceCommission>();

    public virtual ICollection<ServiceFee> ServiceFees { get; } = new List<ServiceFee>();

    public virtual ServiceType? ServiceType { get; set; }
}
