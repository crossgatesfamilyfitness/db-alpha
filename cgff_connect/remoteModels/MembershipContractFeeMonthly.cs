using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MembershipContractFeeMonthly
{
    public uint Id { get; set; }

    /// <summary>
    /// membership_contract
    /// </summary>
    public uint? ContractId { get; set; }

    public int GroupId { get; set; }

    public int? UserId { get; set; }

    public byte RowType { get; set; }

    public uint Row { get; set; }

    public uint Col { get; set; }

    public decimal? Value { get; set; }

    public byte IsDefault { get; set; }

    public decimal? GridValue { get; set; }

    public byte IsHolded { get; set; }

    public decimal FullValue { get; set; }

    public decimal? Discount { get; set; }
}
