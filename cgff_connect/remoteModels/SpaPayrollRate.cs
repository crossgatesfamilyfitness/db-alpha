using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaPayrollRate
{
    public uint Id { get; set; }

    public int UserId { get; set; }

    public decimal HourlyCompensation { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
