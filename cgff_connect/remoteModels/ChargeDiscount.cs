using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChargeDiscount
{
    public ulong Id { get; set; }

    public ulong ChargeId { get; set; }

    public int DiscountId { get; set; }

    public int RowType { get; set; }

    public string DiscountType { get; set; } = null!;

    public decimal DiscountValue { get; set; }

    public decimal Amount { get; set; }
}
