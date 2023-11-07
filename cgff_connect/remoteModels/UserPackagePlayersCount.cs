using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackagePlayersCount
{
    public int UserId { get; set; }

    public uint PackageId { get; set; }

    public int Players { get; set; }
}
