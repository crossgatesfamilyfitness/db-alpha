using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserSetting
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string? Type { get; set; }

    public int IntValue { get; set; }

    public float FloatValue { get; set; }

    public string StringValue { get; set; } = null!;

    public string? ArrayValue { get; set; }

    public string? LastTrack { get; set; }

    public int ModifiedBy { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public DateTime ModifiedDate { get; set; }
}
