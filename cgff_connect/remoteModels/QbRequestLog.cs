using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// QB request dates
/// </summary>
public partial class QbRequestLog
{
    public long Id { get; set; }

    public DateOnly Date { get; set; }

    public string Ip { get; set; } = null!;

    public uint UserId { get; set; }

    public DateOnly RequestDate { get; set; }

    public DateTime RequestTime { get; set; }
}
