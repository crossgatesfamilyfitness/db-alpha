using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServicePricingGroupUserGroup
{
    public int Id { get; set; }

    public int? ServicePricingGroupId { get; set; }

    public int? GroupId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual ServicePricingGroup? ServicePricingGroup { get; set; }
}
