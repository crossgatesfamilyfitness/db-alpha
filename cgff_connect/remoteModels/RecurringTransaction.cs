using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RecurringTransaction
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Description { get; set; } = null!;

    public bool Type { get; set; }

    public decimal Amount { get; set; }

    public int AccGroupId { get; set; }

    public int MonthFrom { get; set; }

    public int MonthTo { get; set; }

    public string Billing { get; set; } = null!;

    public int Count { get; set; }

    public bool? Status { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
