using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupAccountingGroup
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int EntityId { get; set; }

    public sbyte Type { get; set; }

    public int AccountingGroupId { get; set; }
}
