using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Announcement
{
    public uint Id { get; set; }

    public string Title { get; set; } = null!;

    public string? ImageFileName { get; set; }

    public string? VideoUrl { get; set; }

    public string Content { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Active/Inactive
    /// </summary>
    public bool? Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
