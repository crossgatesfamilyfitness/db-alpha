using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Batch
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public bool? Status { get; set; }

    public decimal Sales { get; set; }

    public decimal Payments { get; set; }

    public int PostedBy { get; set; }

    public DateTime PostedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    /// <summary>
    /// club id
    /// </summary>
    public int AccgroupEntityId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
