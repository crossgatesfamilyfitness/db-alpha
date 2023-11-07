using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServicePricingGroup
{
    public int Id { get; set; }

    public int? ComponentId { get; set; }

    public string GroupName { get; set; } = null!;

    public virtual Component? Component { get; set; }

    public virtual ICollection<ServicePricingGroupServiceFee> ServicePricingGroupServiceFees { get; } = new List<ServicePricingGroupServiceFee>();

    public virtual ICollection<ServicePricingGroupServiceType> ServicePricingGroupServiceTypes { get; } = new List<ServicePricingGroupServiceType>();

    public virtual ICollection<ServicePricingGroupUserGroup> ServicePricingGroupUserGroups { get; } = new List<ServicePricingGroupUserGroup>();
}
