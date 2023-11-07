using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Access
{
    public string Type { get; set; } = null!;

    public int GroupId { get; set; }

    public int TargetId { get; set; }

    public int Flag { get; set; }

    public string Action { get; set; } = null!;
}
