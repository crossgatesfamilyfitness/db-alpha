using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Shop Inventory History
/// </summary>
public partial class ShopInventoryHistory
{
    public long Id { get; set; }

    public long ShopItemsId { get; set; }

    public int ShopStoreId { get; set; }

    public int ShopVendorId { get; set; }

    public decimal OldAmount { get; set; }

    public decimal NewAmount { get; set; }

    public decimal Cost { get; set; }

    public DateOnly Date { get; set; }

    public DateTime Datetime { get; set; }

    public sbyte ReasonCode { get; set; }

    public int? AddedBy { get; set; }

    public int? InventoryTransferId { get; set; }
}
