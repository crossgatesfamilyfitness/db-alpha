using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopShortcutItem
{
    public ulong Id { get; set; }

    public ulong CartId { get; set; }

    public ulong ShopItemId { get; set; }

    public decimal ProductPrice { get; set; }
}
