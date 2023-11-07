using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Style
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public sbyte Type { get; set; }

    public bool IsDefault { get; set; }

    public string Settings { get; set; } = null!;
}
