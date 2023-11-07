using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class FirstAchQueue
{
    public int Id { get; set; }

    public string TransId { get; set; } = null!;

    public string TransStatus { get; set; } = null!;

    public string ReasonCode { get; set; } = null!;

    public string? ReasonTitle { get; set; }

    public int Status { get; set; }

    public DateTime Time { get; set; }

    public string Error { get; set; } = null!;

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
