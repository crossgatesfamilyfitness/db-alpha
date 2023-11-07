using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Letter
{
    public uint Id { get; set; }

    public int? ThemeId { get; set; }

    public bool? Main { get; set; }

    public string? Head { get; set; }

    public string? Body { get; set; }
}
