using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MembershipType
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
