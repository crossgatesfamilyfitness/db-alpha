using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CreditCardDeclineCode
{
    public int Id { get; set; }

    public string Gateway { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Processor { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Text { get; set; }
}
