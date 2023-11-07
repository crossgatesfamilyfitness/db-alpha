using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

/// <summary>
/// Table to store barcodes of shop items
/// </summary>
public partial class ShopItemBarcode
{
    public int Id { get; set; }

    public long? ItemId { get; set; }

    public string? Barcode { get; set; }
}
