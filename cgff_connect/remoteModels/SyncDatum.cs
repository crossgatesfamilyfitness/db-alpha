using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SyncDatum
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string Table { get; set; } = null!;

    public int ItemId { get; set; }

    public DateTime Date { get; set; }

    public bool Exported { get; set; }
}
