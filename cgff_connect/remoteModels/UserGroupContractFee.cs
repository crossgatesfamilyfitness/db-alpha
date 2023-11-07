using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupContractFee
{
    public uint ContractId { get; set; }

    public uint ChildId { get; set; }

    public decimal MembershipFee { get; set; }

    public decimal EnrollmentFee { get; set; }
}
