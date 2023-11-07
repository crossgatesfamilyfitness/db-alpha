using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PackageSaleEntity
{
    public uint Id { get; set; }

    public uint PackageId { get; set; }

    public int EntityId { get; set; }
}
