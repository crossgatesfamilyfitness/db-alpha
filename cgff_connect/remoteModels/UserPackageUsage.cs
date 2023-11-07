using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackageUsage
{
    public int Id { get; set; }

    public int UserPackageId { get; set; }

    /// <summary>
    /// it is true if user package usage was migrated from the old logic
    /// </summary>
    public bool WasMigrated { get; set; }

    public sbyte UserPackageStatus { get; set; }

    /// <summary>
    /// number of used sessions
    /// </summary>
    public decimal NumberOfSessions { get; set; }

    public string Operation { get; set; } = null!;

    public string OperationType { get; set; } = null!;

    /// <summary>
    /// related event
    /// </summary>
    public int? EventId { get; set; }

    /// <summary>
    /// related schedule
    /// </summary>
    public ulong? ScheduleId { get; set; }

    /// <summary>
    /// related payment
    /// </summary>
    public ulong? PaymentId { get; set; }

    /// <summary>
    /// related charge
    /// </summary>
    public ulong? ChargeId { get; set; }

    /// <summary>
    /// related refund receipt
    /// </summary>
    public uint? RefundReceiptId { get; set; }

    /// <summary>
    /// description of operation
    /// </summary>
    public string? Description { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public string? LastTrack { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
