using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserOffsiteAddress
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public sbyte Type { get; set; }

    public string StreetAddress { get; set; } = null!;

    public string StreetAddress2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? Country { get; set; }

    public long? AddressId { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public virtual Address? Address { get; set; }
}
