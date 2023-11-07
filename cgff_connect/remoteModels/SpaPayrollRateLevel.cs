using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaPayrollRateLevel
{
    public uint Id { get; set; }

    public uint PayrollRateId { get; set; }

    public string Type { get; set; } = null!;

    public decimal From { get; set; }

    public decimal To { get; set; }

    public int Earning { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
