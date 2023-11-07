using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MembershipFee
{
    public uint Id { get; set; }

    public int? GroupId { get; set; }

    public decimal MembershipFee1 { get; set; }

    public decimal EnrollmentFee { get; set; }

    public decimal? StartAge { get; set; }

    public decimal? EndAge { get; set; }

    public bool Type { get; set; }

    public int? Order { get; set; }

    public virtual Group? Group { get; set; }
}
