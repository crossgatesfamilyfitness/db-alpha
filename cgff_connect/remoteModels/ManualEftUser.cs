using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ManualEftUser
{
    public long Id { get; set; }

    public int BulkEftId { get; set; }

    public int UserId { get; set; }

    public DateOnly BalanceDate { get; set; }

    public sbyte Status { get; set; }

    public string? EftResult { get; set; }
}
