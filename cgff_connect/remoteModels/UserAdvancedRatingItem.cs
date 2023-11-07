using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserAdvancedRatingItem
{
    public int Id { get; set; }

    public int AdvancedRatingItemId { get; set; }

    public int UserId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CompletedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
