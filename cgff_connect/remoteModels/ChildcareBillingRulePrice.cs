using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChildcareBillingRulePrice
{
    public int Id { get; set; }

    public uint ChildcareBillingRuleId { get; set; }

    public decimal? AgeFrom { get; set; }

    public decimal? AgeTo { get; set; }

    public decimal? Rate { get; set; }

    public virtual ChildcareBillingRule ChildcareBillingRule { get; set; } = null!;
}
