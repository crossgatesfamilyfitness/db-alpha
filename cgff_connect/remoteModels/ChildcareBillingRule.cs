using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChildcareBillingRule
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string BillingType { get; set; } = null!;

    public string BillingRate { get; set; } = null!;

    public string Rounding { get; set; } = null!;

    public short RoundingIncrement { get; set; }

    public int? AccGroupId { get; set; }

    public string StatementDescription { get; set; } = null!;

    public sbyte IsDefault { get; set; }

    public virtual ICollection<ChildcareBillingRulePrice> ChildcareBillingRulePrices { get; } = new List<ChildcareBillingRulePrice>();
}
