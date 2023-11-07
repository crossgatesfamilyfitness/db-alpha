using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppleWalletLog
{
    public uint Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Message { get; set; }
}
