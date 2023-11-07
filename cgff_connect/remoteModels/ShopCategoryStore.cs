using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopCategoryStore
{
    public int ShopCategoryId { get; set; }

    public int ShopStoreId { get; set; }

    public string Status { get; set; } = null!;

    public int DefaultAccountingGroupId { get; set; }
}
