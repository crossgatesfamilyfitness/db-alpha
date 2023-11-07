using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ShopItemAdjustmentReason
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Active { get; set; }

    public bool Default { get; set; }

    public bool? System { get; set; }
}
