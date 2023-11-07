using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class DiscountCodeUsage
{
    public long Id { get; set; }

    public int? UserId { get; set; }

    public long? DiscountCodeId { get; set; }

    public int? UserGroupSubscriptionId { get; set; }

    public virtual DiscountCode? DiscountCode { get; set; }

    public virtual ICollection<DiscountCodeUsageDetail> DiscountCodeUsageDetails { get; } = new List<DiscountCodeUsageDetail>();

    public virtual User? User { get; set; }

    public virtual UserGroupSubscription? UserGroupSubscription { get; set; }
}
