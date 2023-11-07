using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class AccountingGroupItem
{
    public int Id { get; set; }

    public int AccountingGroupId { get; set; }

    public int? ItemId { get; set; }

    public string? Name { get; set; }

    public float? Price { get; set; }
}
