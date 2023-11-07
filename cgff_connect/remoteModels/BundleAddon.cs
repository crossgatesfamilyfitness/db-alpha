using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BundleAddon
{
    public int Id { get; set; }

    public int BundleId { get; set; }

    public int AddonId { get; set; }

    public string? DelayIntervalType { get; set; }

    public short? DelayIntervalAmount { get; set; }

    public string? DelayIntervalBillType { get; set; }

    public short? StartDay { get; set; }

    public short? StartMonth { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
