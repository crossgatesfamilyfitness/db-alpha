using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PayrollTemplate
{
    public uint Id { get; set; }

    public int ComponentId { get; set; }

    public string Name { get; set; } = null!;

    public string? Settings { get; set; }
}
