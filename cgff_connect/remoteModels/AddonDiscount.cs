using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AddonDiscount
{
    public uint Id { get; set; }

    public int AddonId { get; set; }

    public int AccountingGroupId { get; set; }

    public decimal Fee { get; set; }

    public string Type { get; set; } = null!;

    public virtual AccountingGroup AccountingGroup { get; set; } = null!;

    public virtual Group Addon { get; set; } = null!;
}
