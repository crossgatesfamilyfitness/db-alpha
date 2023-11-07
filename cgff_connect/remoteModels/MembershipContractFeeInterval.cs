using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MembershipContractFeeInterval
{
    public uint Id { get; set; }

    /// <summary>
    /// membership_contract
    /// </summary>
    public uint? ContractId { get; set; }

    public int GroupId { get; set; }

    public int? UserId { get; set; }

    public byte RowType { get; set; }

    public decimal? MembershipFee { get; set; }

    public decimal? StartAge { get; set; }

    public decimal? EndAge { get; set; }

    public byte? DependentType { get; set; }

    public int? Order { get; set; }

    public byte IsDefault { get; set; }

    public decimal? Discount { get; set; }
}
