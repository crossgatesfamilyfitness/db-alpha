using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineMemberCartGroupItem
{
    public uint Id { get; set; }

    public uint? OnlineCartId { get; set; }

    public uint OnlineMemberCartItemId { get; set; }

    public uint GroupId { get; set; }

    public uint NumberOfDependents { get; set; }

    public uint EntityId { get; set; }

    public int? SecondaryUserId { get; set; }

    public string? DependentUserIds { get; set; }

    public string? DelayIntervalType { get; set; }

    public short? DelayIntervalAmount { get; set; }

    public string? DelayIntervalBillType { get; set; }

    public short? StartDay { get; set; }

    public short? StartMonth { get; set; }
}
