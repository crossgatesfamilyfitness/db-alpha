using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupAdditionalCharge
{
    public uint Id { get; set; }

    public int GroupId { get; set; }

    public string Description { get; set; } = null!;

    public decimal Fee { get; set; }
}
