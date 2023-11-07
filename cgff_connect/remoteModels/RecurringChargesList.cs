using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RecurringChargesList
{
    public ulong Id { get; set; }

    public sbyte Type { get; set; }

    public byte Status { get; set; }

    public DateOnly? HoldDate { get; set; }

    public int UserId { get; set; }

    public DateOnly DateFrom { get; set; }

    public DateOnly DateTo { get; set; }

    public float Price { get; set; }

    public string Description { get; set; } = null!;

    public ulong EventId { get; set; }

    public ulong ScheduleId { get; set; }

    public int ResourceId { get; set; }

    public int GroupId { get; set; }

    public int UserFor { get; set; }

    public DateTime LastBillDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
