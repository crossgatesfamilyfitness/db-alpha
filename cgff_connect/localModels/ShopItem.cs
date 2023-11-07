using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ShopItem
{
    public ulong Id { get; set; }

    public string? Name { get; set; }

    public string ItemNumber { get; set; } = null!;

    public float? Price { get; set; }

    public float Cost { get; set; }

    public float AvgCost { get; set; }

    public decimal Amount { get; set; }

    public uint? Category { get; set; }

    public int ManufacturerId { get; set; }

    public int ComponentId { get; set; }

    public int AccGroupId { get; set; }

    public string? Description { get; set; }

    public float? Tax { get; set; }

    public int TaxRateId { get; set; }

    public byte Taxable { get; set; }

    public float Payroll { get; set; }

    public DateTime DateCreated { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public sbyte Status { get; set; }

    public int EntityId { get; set; }

    /// <summary>
    /// JSON-encoded rules to calculate price.
    /// </summary>
    public string PriceRules { get; set; } = null!;

    /// <summary>
    /// label for schedule grid
    /// </summary>
    public string Label { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }
}
