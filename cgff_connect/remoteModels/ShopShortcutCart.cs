using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopShortcutCart
{
    public ulong Id { get; set; }

    public string DashboardItemId { get; set; } = null!;

    public ulong ShopItemId { get; set; }

    public int UserId { get; set; }

    public string? Note { get; set; }

    public decimal Price { get; set; }

    public decimal ProductPrice { get; set; }

    public decimal Cost { get; set; }
}
