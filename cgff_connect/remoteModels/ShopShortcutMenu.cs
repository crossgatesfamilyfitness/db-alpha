using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopShortcutMenu
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public int ShopStoreId { get; set; }

    public byte Status { get; set; }

    public string DashboardItemId { get; set; } = null!;
}
