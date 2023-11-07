using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StatementEmailQueue
{
    public uint Id { get; set; }

    public string? JsonParams { get; set; }

    public bool? Status { get; set; }

    public bool Removed { get; set; }
}
