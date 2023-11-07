using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CaDashboardItem
{
    public int UserId { get; set; }

    public string ItemId { get; set; } = null!;

    public string? Params { get; set; }
}
