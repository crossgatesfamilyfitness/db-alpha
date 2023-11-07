using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Tbatch
{
    public ulong Id { get; set; }

    public int? AccountingGroupId { get; set; }

    public DateTime DateCreated { get; set; }

    public float TotalAmount { get; set; }

    public int? MemberId { get; set; }

    public string? Type { get; set; }

    public string TransactionType { get; set; } = null!;
}
