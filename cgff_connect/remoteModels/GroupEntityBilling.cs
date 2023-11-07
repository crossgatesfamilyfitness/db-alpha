using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// This table will define which memberships can be sold to which locations. In addition, we will also be able to define and map what the fees will be, based on the user&apos;s home location (entity)
/// </summary>
public partial class GroupEntityBilling
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? EntityId { get; set; }

    /// <summary>
    /// Control from what location a user can actually sell a membership
    /// </summary>
    public sbyte CanSell { get; set; }

    /// <summary>
    /// Control which entities the sale of a membership can be mapped to
    /// </summary>
    public sbyte MapRevenue { get; set; }

    public bool HasContractOptions { get; set; }

    public short CycleCount { get; set; }

    public short CycleCountRenew { get; set; }

    public string CycleRenewType { get; set; } = null!;

    /// <summary>
    /// Days before new billing cycle will start
    /// </summary>
    public short RenewBefore { get; set; }

    public string StartDate { get; set; } = null!;

    public sbyte DefaultBillOnDate { get; set; }

    public string HoldType { get; set; } = null!;

    public decimal HoldValue { get; set; }

    public bool? ProrateFirstMonth { get; set; }

    public bool IsActive { get; set; }

    public bool LockDefaultPrice { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
