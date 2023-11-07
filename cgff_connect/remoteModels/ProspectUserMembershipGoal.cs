using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ProspectUserMembershipGoal
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public int MembershipGoalId { get; set; }
}
