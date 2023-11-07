using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BillingGroup
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Amount { get; set; }

    public string AmountType { get; set; } = null!;

    public bool DiscountAsStatement { get; set; }

    public int? BillToAccount { get; set; }

    public bool BillToAccType { get; set; }

    public decimal BillToValue { get; set; }

    public string BillToType { get; set; } = null!;

    public bool ProrateOptions { get; set; }

    public DateOnly Created { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
