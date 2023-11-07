using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PrintjobParam
{
    public int PrintjobId { get; set; }

    public string? JsonParams { get; set; }

    public int? RecipientId { get; set; }
}
