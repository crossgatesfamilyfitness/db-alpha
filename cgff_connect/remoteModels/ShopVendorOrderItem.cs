using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Shop Vendor Order Item
/// </summary>
public partial class ShopVendorOrderItem
{
    public int ShopVendorOrderId { get; set; }

    public long ShopItemId { get; set; }
}
