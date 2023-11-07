using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServicePricingGroupServiceType
{
    public int Id { get; set; }

    public int? ServicePricingGroupId { get; set; }

    public int? ServiceTypeId { get; set; }

    public virtual ServicePricingGroup? ServicePricingGroup { get; set; }

    public virtual ServiceType? ServiceType { get; set; }
}
