using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AddonResource
{
    public int Id { get; set; }

    public int AddonId { get; set; }

    public int SubAddonId { get; set; }

    public string Name { get; set; } = null!;

    public int LocationId { get; set; }

    public int TypeId { get; set; }

    public sbyte Status { get; set; }

    public bool Removed { get; set; }

    public string Prefix { get; set; } = null!;

    public int Number { get; set; }

    public string Suffix { get; set; } = null!;

    public bool? Available { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual Group Addon { get; set; } = null!;

    public virtual ICollection<AddonResourceNote> AddonResourceNotes { get; } = new List<AddonResourceNote>();

    public virtual AddonResourceLocation Location { get; set; } = null!;

    public virtual AddonResourceType Type { get; set; } = null!;
}
