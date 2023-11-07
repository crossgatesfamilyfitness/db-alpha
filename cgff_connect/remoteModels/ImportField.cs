using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportField
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Example { get; set; }

    public string? Description { get; set; }
}
