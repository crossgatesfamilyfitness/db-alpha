using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServicePricingGroupServiceFee
{
    public int Id { get; set; }

    public int? ServicePricingGroupId { get; set; }

    public ulong? ServiceFeeId { get; set; }

    public decimal? Fee { get; set; }

    public virtual ServiceFee? ServiceFee { get; set; }

    public virtual ServicePricingGroup? ServicePricingGroup { get; set; }
}
