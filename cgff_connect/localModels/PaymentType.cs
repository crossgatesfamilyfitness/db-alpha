using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class PaymentType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? GlCode { get; set; }

    public string? AccGroupName { get; set; }

    public sbyte System { get; set; }

    public sbyte QbExport { get; set; }

    public int Sort { get; set; }

    public bool PosEnabled { get; set; }

    public bool StatementEnabled { get; set; }

    public bool BatchEnabled { get; set; }
}
