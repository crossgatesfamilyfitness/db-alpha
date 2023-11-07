using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ComponentSetting
{
    public int Id { get; set; }

    public int ComponentId { get; set; }

    public string Name { get; set; } = null!;

    public string? Type { get; set; }

    public int IntValue { get; set; }

    public float FloatValue { get; set; }

    public string StringValue { get; set; } = null!;

    public string? ArrayValue { get; set; }

    public int EntityId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
