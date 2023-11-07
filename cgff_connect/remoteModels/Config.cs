using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Config
{
    public int Id { get; set; }

    public string Module { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Label { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Access { get; set; }

    public string Value { get; set; } = null!;
}
