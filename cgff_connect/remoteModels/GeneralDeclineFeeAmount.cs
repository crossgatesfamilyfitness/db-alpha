using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GeneralDeclineFeeAmount
{
    public int Id { get; set; }

    public string ScheduleType { get; set; } = null!;

    public bool? DayOfMonth { get; set; }

    public int EntityId { get; set; }

    public int AccGroupId { get; set; }

    public int PaymentMethodId { get; set; }

    public decimal FeeAmount { get; set; }
}
