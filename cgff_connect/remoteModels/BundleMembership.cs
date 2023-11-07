using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BundleMembership
{
    public int Id { get; set; }

    public int BundleId { get; set; }

    public int MembershipId { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
