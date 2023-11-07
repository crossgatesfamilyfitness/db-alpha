using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class InfrastructureRateSetting
{
    public int Id { get; set; }

    public int RateId { get; set; }

    public int AccountingGroupId { get; set; }

    public int EntityId { get; set; }
}
