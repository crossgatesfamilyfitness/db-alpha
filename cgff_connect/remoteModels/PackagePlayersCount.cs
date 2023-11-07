using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PackagePlayersCount
{
    public uint PackageId { get; set; }

    public int Players { get; set; }
}
