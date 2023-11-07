using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Feature
{
    public string Name { get; set; } = null!;

    public bool Status { get; set; }

    public int AccgroupEntityId { get; set; }
}
