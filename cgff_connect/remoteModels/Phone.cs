using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Phone
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    public string? PhoneType { get; set; }

    public string Number { get; set; } = null!;

    public string? Name { get; set; }

    public string? Relation { get; set; }

    public string Email { get; set; } = null!;

    public byte? Primary { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public string NumberDigits { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
