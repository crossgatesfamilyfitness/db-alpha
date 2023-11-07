using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CaDashboard
{
    public int UserId { get; set; }

    public string ItemId { get; set; } = null!;

    public string? Type { get; set; }

    public string Col1 { get; set; } = null!;

    public string Col2 { get; set; } = null!;

    public string Col3 { get; set; } = null!;
}
