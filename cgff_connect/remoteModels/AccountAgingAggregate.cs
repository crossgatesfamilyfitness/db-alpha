using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AccountAgingAggregate
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public int? EntityId { get; set; }

    /// <summary>
    /// 1 - daily, 2 - monthly, 3 - quarterly, 4 - yearly
    /// </summary>
    public sbyte AggregateType { get; set; }

    public DateOnly PeriodStart { get; set; }

    public DateOnly PeriodEnd { get; set; }

    public DateOnly EffectiveFrom { get; set; }

    public decimal Balance { get; set; }

    public decimal Credit { get; set; }
}
