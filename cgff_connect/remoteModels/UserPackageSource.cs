using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackageSource
{
    public long Id { get; set; }

    public int UserPackageId { get; set; }

    public bool Source { get; set; }
}
