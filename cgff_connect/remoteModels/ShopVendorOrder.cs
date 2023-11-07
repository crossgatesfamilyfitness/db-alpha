using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Shop Vendor Order
/// </summary>
public partial class ShopVendorOrder
{
    public int Id { get; set; }

    public int ShopVendorId { get; set; }
}
