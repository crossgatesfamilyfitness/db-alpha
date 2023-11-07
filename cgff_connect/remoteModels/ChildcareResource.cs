using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChildcareResource
{
    public ulong Id { get; set; }

    public uint? YearFrom { get; set; }

    public uint? MonthFrom { get; set; }

    public uint? YearTo { get; set; }

    public uint? MonthTo { get; set; }

    public uint? StaffChildRatio { get; set; }

    public uint? Capacity { get; set; }

    public uint Order { get; set; }

    public int? EntityId { get; set; }

    public sbyte Status { get; set; }

    public int? AccountingGroupId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
