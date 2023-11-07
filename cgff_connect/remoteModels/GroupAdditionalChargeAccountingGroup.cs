using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupAdditionalChargeAccountingGroup
{
    public uint Id { get; set; }

    public uint AccountingGroupId { get; set; }

    public uint EntityId { get; set; }

    public ulong AdditionalChargeId { get; set; }
}
