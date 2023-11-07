using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CheckinRule
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string Settings { get; set; } = null!;

    public bool? Status { get; set; }
}
