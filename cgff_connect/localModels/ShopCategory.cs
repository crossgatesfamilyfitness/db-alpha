using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ShopCategory
{
    public ushort Id { get; set; }

    public int ComponentId { get; set; }

    public short ParentId { get; set; }

    public string? Title { get; set; }

    public bool? AllStores { get; set; }

    public string? Description { get; set; }

    public bool PrintKitchenReceipt { get; set; }

    public bool? Status { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
