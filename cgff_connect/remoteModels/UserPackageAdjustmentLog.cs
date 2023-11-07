using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackageAdjustmentLog
{
    public int Id { get; set; }

    public int UserPackageId { get; set; }

    public decimal InitialPrice { get; set; }

    public decimal InitialSessions { get; set; }

    public decimal ExpectedPricePerSession { get; set; }

    public decimal RemainingPrice { get; set; }

    public decimal RemainingSessions { get; set; }

    public decimal CurrentPricePerSession { get; set; }

    /// <summary>
    /// adjustment credit for past payments
    /// </summary>
    public ulong? AdjustmentCreditId { get; set; }

    /// <summary>
    /// adjustment charge for past payments
    /// </summary>
    public ulong? AdjustmentChargeId { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public string? LastTrack { get; set; }
}
