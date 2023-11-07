using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopOrder
{
    public ulong Id { get; set; }

    public uint? User { get; set; }

    public DateTime Date { get; set; }

    public string Status { get; set; } = null!;

    public uint Total { get; set; }
}
