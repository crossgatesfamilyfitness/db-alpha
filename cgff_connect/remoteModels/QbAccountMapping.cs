using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QbAccountMapping
{
    public string QbId { get; set; } = null!;

    public int AccGroupId { get; set; }
}
