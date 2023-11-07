using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Printjob
{
    public uint Id { get; set; }

    public string? Type { get; set; }

    public string Name { get; set; } = null!;

    public string? Content { get; set; }

    public uint UserId { get; set; }

    public DateTime Datetime { get; set; }

    public int NeedLabel { get; set; }

    public bool? Status { get; set; }

    public bool Removed { get; set; }

    public string File { get; set; } = null!;
}
