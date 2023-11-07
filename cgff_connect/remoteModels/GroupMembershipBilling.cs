using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupMembershipBilling
{
    public uint Id { get; set; }

    public int? GroupId { get; set; }

    public byte? Month { get; set; }

    public byte? Type { get; set; }

    public bool IsSecond { get; set; }

    public virtual Group? Group { get; set; }
}
