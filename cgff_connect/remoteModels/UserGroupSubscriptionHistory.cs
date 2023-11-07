using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionHistory
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public int? SubscriptionBillingOptionId { get; set; }

    public int? SubscriptionBillingOptionChangeFrom { get; set; }

    public int? SubscriptionBillingOptionChangeTo { get; set; }

    public int? SubscriptionId { get; set; }

    public int? SubscriptionStatusId { get; set; }

    public int? UserId { get; set; }

    public int? GroupId { get; set; }

    public string FamilyRole { get; set; } = null!;

    public string? StatusFrom { get; set; }

    public string StatusTo { get; set; } = null!;

    public int Order { get; set; }

    public bool? LastInDay { get; set; }

    public int? PrimaryUserId { get; set; }

    public int? SecondaryUserId { get; set; }

    public string? DependentUserIds { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public DateOnly? CancellationDate { get; set; }

    public string CancellationReason { get; set; } = null!;

    public DateOnly? HoldStartDate { get; set; }

    public DateOnly? HoldEndDate { get; set; }

    public string HoldReason { get; set; } = null!;

    public int? SaleEntityId { get; set; }

    public int? MapRevenueEntityId { get; set; }

    public decimal? BaseFee { get; set; }

    public int? BillTo { get; set; }

    public decimal? BillToAmount { get; set; }

    public string? BillToType { get; set; }

    public int? ReferredBy { get; set; }

    public decimal? ReferredByAmount { get; set; }

    public string? ReferredByType { get; set; }

    public string? SalesAssociateIds { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public int ModifiedByIntranet { get; set; }

    public string LastTrack { get; set; } = null!;
}
