using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LockerBillingType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint MonthCnt { get; set; }

    public sbyte Month { get; set; }

    public sbyte Day { get; set; }
}
