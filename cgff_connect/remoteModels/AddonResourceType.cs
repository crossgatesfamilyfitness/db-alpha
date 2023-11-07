using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AddonResourceType
{
    public int Id { get; set; }

    public int AddonId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }

    public virtual ICollection<AddonResource> AddonResources { get; } = new List<AddonResource>();
}
