using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscription
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public int? UserGroupSubscriptionBillingOptionId { get; set; }

    public int? UserId { get; set; }

    public int? GroupId { get; set; }

    public string FamilyRole { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public bool? IsActive { get; set; }

    public int? AddedBy { get; set; }

    public string HowAdded { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual ICollection<DiscountCodeUsage> DiscountCodeUsages { get; } = new List<DiscountCodeUsage>();
}
