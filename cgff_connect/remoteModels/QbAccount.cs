using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QbAccount
{
    public string ListId { get; set; } = null!;

    public int Sublevel { get; set; }

    public string FullName { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Number { get; set; }
}
