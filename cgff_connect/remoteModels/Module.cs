using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Module
{
    public int Id { get; set; }

    public int InstallationId { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Parametrs { get; set; } = null!;

    public int? Ordering { get; set; }
}
