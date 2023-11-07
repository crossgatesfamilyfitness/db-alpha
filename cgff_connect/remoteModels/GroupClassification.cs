using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupClassification
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GroupMembershipClassification> GroupMembershipClassifications { get; } = new List<GroupMembershipClassification>();
}
