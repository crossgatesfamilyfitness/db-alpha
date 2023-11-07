using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionBillingOption
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? GroupEntityBillingId { get; set; }

    public int? RenewalId { get; set; }

    public int? ChangeToId { get; set; }

    public short? CycleCount { get; set; }

    public bool HasAgreement { get; set; }

    public bool? BillingDay { get; set; }

    public DateOnly StartBillingDate { get; set; }

    public DateOnly? CycleStartBillingDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public string CycleRenewType { get; set; } = null!;

    public short? CycleCountRenew { get; set; }

    /// <summary>
    /// Days before new billing cycle will start
    /// </summary>
    public short? RenewBefore { get; set; }

    public bool? ProrateFirstMonth { get; set; }

    public bool DiscountAsStatement { get; set; }

    public int? ContractTermsId { get; set; }

    public int? BillTo { get; set; }

    public decimal BillToAmount { get; set; }

    public string BillToType { get; set; } = null!;

    public int? ReferredBy { get; set; }

    public decimal ReferredByAmount { get; set; }

    public string ReferredByType { get; set; } = null!;

    public int? MapRevenueEntityId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
