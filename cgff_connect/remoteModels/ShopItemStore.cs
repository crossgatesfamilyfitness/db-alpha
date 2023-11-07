using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Shop Item Store
/// </summary>
public partial class ShopItemStore
{
    public long ShopItemsId { get; set; }

    public int ShopStoreId { get; set; }

    public decimal Amount { get; set; }

    public int AccountingGroupId { get; set; }

    public bool? Available { get; set; }

    public decimal? AverageCost { get; set; }
}
