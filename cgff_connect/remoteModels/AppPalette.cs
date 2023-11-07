using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppPalette
{
    public ulong Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Data { get; set; }

    public DateTime CreatedTime { get; set; }

    public uint? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public uint? UpdatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public uint? DeletedBy { get; set; }

    public DateTime? SubmittedTime { get; set; }

    public uint? SubmittedBy { get; set; }
}
