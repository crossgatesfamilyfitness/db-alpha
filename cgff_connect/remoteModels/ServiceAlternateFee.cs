using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceAlternateFee
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public int? ServiceId { get; set; }

    public int? EntityId { get; set; }

    public string FeeType { get; set; } = null!;

    public int? FeeAccGroupId { get; set; }

    public decimal Fee { get; set; }

    public bool IsPercentageServiceFee { get; set; }

    public bool IsFullCharge { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual AccountingGroup? FeeAccGroup { get; set; }

    public virtual Service? Service { get; set; }

    public virtual ServiceType? ServiceType { get; set; }
}
