using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AdvancedRating
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public int Level { get; set; }

    public string? Description { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public bool? Active { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
