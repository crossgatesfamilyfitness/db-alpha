using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Penalty
{
    public uint Id { get; set; }

    public string Title { get; set; } = null!;

    public float Amount { get; set; }

    public string Type { get; set; } = null!;

    public int AccountingGroupId { get; set; }

    public int Category { get; set; }

    public string LinkedMemberships { get; set; } = null!;
}
