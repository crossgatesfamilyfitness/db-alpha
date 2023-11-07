using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupMembershipClassification
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int GroupClassificationId { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual GroupClassification GroupClassification { get; set; } = null!;
}
