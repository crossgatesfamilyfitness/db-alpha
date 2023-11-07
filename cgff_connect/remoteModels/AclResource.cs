using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AclResource
{
    public string Id { get; set; } = null!;

    public string? ParentId { get; set; }

    public sbyte Type { get; set; }
}
