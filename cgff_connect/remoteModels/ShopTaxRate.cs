using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopTaxRate
{
    public int Id { get; set; }

    public int IndexNumber { get; set; }

    public decimal Rate { get; set; }

    public sbyte Status { get; set; }

    public string? GlCode { get; set; }

    public string TaxName { get; set; } = null!;

    public string? AccGroupName { get; set; }
}
