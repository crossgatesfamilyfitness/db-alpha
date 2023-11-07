using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackageDuration
{
    public int Id { get; set; }

    public int UserPackageId { get; set; }

    public short Duration { get; set; }
}
