using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CheckinUserRule
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public int UserId { get; set; }

    public string Settings { get; set; } = null!;

    public string Errors { get; set; } = null!;

    public DateOnly LastUpdate { get; set; }

    public bool Status { get; set; }
}
