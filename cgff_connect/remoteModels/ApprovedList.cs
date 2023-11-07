using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ApprovedList
{
    public uint EventId { get; set; }

    public uint UserId { get; set; }

    public int GroupId { get; set; }

    public bool? Allowed { get; set; }
}
