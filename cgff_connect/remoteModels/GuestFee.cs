using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GuestFee
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string MemberGroups { get; set; } = null!;

    public string Season { get; set; } = null!;

    public string Services { get; set; } = null!;

    public string Locations { get; set; } = null!;

    public string Days { get; set; } = null!;

    public bool? WholeDay { get; set; }

    public TimeOnly TimeFrom { get; set; }

    public TimeOnly TimeTo { get; set; }

    public int LimitFrom { get; set; }

    public int LimitTo { get; set; }

    public string LimitPeriod { get; set; } = null!;

    public float Fee { get; set; }

    public string FeeType { get; set; } = null!;

    public int? AccountingGroup { get; set; }

    public string? GuestFeeDescription { get; set; }
}
