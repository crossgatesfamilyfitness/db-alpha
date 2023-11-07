using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Discount
{
    public int Id { get; set; }

    public string Barcode { get; set; } = null!;

    public string Title { get; set; } = null!;

    public float Amount { get; set; }

    public string Descripiton { get; set; } = null!;

    public string Status { get; set; } = null!;

    public sbyte Type { get; set; }

    public string? Params { get; set; }
}
