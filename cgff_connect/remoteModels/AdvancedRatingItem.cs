using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AdvancedRatingItem
{
    public int Id { get; set; }

    public int AdvancedRatingId { get; set; }

    public int Sequence { get; set; }

    public string Group { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Instruction { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public bool? Active { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
