using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SettingClub
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string Name { get; set; } = null!;

    public string? Type { get; set; }

    public int IntValue { get; set; }

    public float FloatValue { get; set; }

    public string StringValue { get; set; } = null!;

    public string? ArrayValue { get; set; }

    public string? TextValue { get; set; }
}
