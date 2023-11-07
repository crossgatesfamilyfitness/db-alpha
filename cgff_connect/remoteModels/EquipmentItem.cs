using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EquipmentItem
{
    public int Id { get; set; }

    public string Barcode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public float LateFee { get; set; }

    public int AccGroupId { get; set; }

    public string Status { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? CheckoutOption { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
