using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopCart
{
    public ulong Id { get; set; }

    public ulong? Item { get; set; }

    public long ChargeId { get; set; }

    public string ItemType { get; set; } = null!;

    public uint? Order { get; set; }

    public decimal Amount { get; set; }

    public decimal DiscountRate { get; set; }

    public string AllDiscountRates { get; set; } = null!;

    public int PosId { get; set; }

    public string Barcode { get; set; } = null!;

    public int? SoldBy { get; set; }
}
