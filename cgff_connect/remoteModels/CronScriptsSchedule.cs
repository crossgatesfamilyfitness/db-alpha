using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CronScriptsSchedule
{
    public int Id { get; set; }

    public int CronId { get; set; }

    public DateOnly LaunchDate { get; set; }

    public TimeOnly? LaunchTime { get; set; }

    public sbyte Type { get; set; }

    public DateTime BillingTillDate { get; set; }

    public sbyte Status { get; set; }

    public string? ErrorMsg { get; set; }

    public int BillingDay { get; set; }

    public string? Params { get; set; }

    public string? ExecutionParams { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
