using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class DiscountCodeDetail
{
    public long Id { get; set; }

    public long? DiscountCodeId { get; set; }

    public string? EnrollmentDiscountMethod { get; set; }

    public decimal? EnrollmentDiscountValue { get; set; }

    public string? CycleDiscountMethod { get; set; }

    public decimal? CycleDiscountValue { get; set; }

    public int? CycleDiscountCount { get; set; }

    public string? AdditionalDiscountMethod { get; set; }

    public decimal? AdditionalDiscountValue { get; set; }

    public virtual DiscountCode? DiscountCode { get; set; }

    public virtual ICollection<DiscountCodeDetailGroup> DiscountCodeDetailGroups { get; } = new List<DiscountCodeDetailGroup>();
}
