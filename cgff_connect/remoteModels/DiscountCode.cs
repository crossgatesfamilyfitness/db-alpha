using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class DiscountCode
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public bool? Active { get; set; }

    public bool Reusable { get; set; }

    public bool IsAutomatic { get; set; }

    public virtual ICollection<DiscountCodeDetail> DiscountCodeDetails { get; } = new List<DiscountCodeDetail>();

    public virtual ICollection<DiscountCodeUsage> DiscountCodeUsages { get; } = new List<DiscountCodeUsage>();
}
