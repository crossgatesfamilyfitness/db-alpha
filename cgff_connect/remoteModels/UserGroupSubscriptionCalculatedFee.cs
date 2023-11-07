using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionCalculatedFee
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? UserGroupSubscriptionId { get; set; }

    public int? UserContractId { get; set; }

    public int? UserGroupSubscriptionBillingOptionId { get; set; }

    /// <summary>
    /// Uses for credit fees
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Uses for maintenance fees
    /// </summary>
    public int? UserGroupSubscriptionMaintenanceFeeId { get; set; }

    public short Cycle { get; set; }

    public string FeeType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateOnly BillDate { get; set; }

    public decimal BillAmount { get; set; }

    public int? BillToHolderId { get; set; }

    public int? BillToUserId { get; set; }

    public int? MapRevenueEntityId { get; set; }

    public int? AccountingGroupId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal? DefaultAmount { get; set; }

    public decimal? CycleDefaultAmount { get; set; }

    public decimal? DiscountedAmount { get; set; }

    public decimal? CorporateDiscountedAmount { get; set; }

    public decimal? ProrateAmount { get; set; }

    public decimal? CycleDiscountedAmount { get; set; }

    public decimal? HoldAmount { get; set; }

    public int? LocationOfSaleEntityId { get; set; }

    public string? FamilyType { get; set; }

    public string StatementDescription { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
