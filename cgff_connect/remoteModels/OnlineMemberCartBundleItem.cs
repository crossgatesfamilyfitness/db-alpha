using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineMemberCartBundleItem
{
    public uint Id { get; set; }

    public uint? OnlineCartId { get; set; }

    public uint OnlineMemberCartItemId { get; set; }

    public uint BundleId { get; set; }

    public uint NumberOfDependents { get; set; }

    public uint EntityId { get; set; }

    public int? SecondaryUserId { get; set; }

    public string? DependentUserIds { get; set; }
}
