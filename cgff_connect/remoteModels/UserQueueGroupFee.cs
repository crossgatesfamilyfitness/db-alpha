using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserQueueGroupFee
{
    public uint UserId { get; set; }

    public uint GroupId { get; set; }

    public uint GroupIdOld { get; set; }

    public uint ChildId { get; set; }

    public decimal MembershipFee { get; set; }

    public decimal EnrollmentFee { get; set; }

    public int? Order { get; set; }
}
