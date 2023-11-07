using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CashflowInfrastructureRate
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public int CashflowRateId { get; set; }

    public string RateName { get; set; } = null!;
}
