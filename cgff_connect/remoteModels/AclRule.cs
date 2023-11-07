using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AclRule
{
    public int Id { get; set; }

    public string ResourceId { get; set; } = null!;

    public string RoleId { get; set; } = null!;

    public string Privilege { get; set; } = null!;

    public sbyte IsAllowed { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
