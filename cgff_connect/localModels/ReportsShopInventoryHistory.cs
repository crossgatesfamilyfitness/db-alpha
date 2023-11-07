using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ReportsShopInventoryHistory
{
    public int Id { get; set; }

    public int? ReportsId { get; set; }

    public int? ShopInventoryHistoryId { get; set; }
}
