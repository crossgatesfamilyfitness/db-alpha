using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackageLocation
{
    public int UserId { get; set; }

    public uint PackageId { get; set; }

    public int LocationId { get; set; }
}
