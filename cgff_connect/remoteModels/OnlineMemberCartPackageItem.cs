using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineMemberCartPackageItem
{
    public uint Id { get; set; }

    public uint? OnlineCartId { get; set; }

    public uint OnlineMemberCartItemId { get; set; }

    public uint PackageId { get; set; }

    public uint? RateId { get; set; }

    public uint EntityId { get; set; }
}
