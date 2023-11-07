using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Membership
{
    public ulong Id { get; set; }

    public int? PrimaryId { get; set; }

    public uint UserId { get; set; }

    public int GroupId { get; set; }

    public DateOnly DateFrom { get; set; }

    public DateOnly DateTo { get; set; }

    public float Price { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? HoldDate { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public int ParentMembershipId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
