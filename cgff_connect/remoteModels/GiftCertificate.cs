using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GiftCertificate
{
    public int Id { get; set; }

    public uint Buyer { get; set; }

    public uint? Receiver { get; set; }

    public decimal Amount { get; set; }

    public decimal OriginalAmount { get; set; }

    public decimal RefundedAmount { get; set; }

    public DateTime? Activated { get; set; }

    public string Code { get; set; } = null!;

    public sbyte CanActivate { get; set; }

    public DateTime? LastUsedDate { get; set; }

    public int EntityId { get; set; }

    public int? CertificateTypeId { get; set; }

    public string CertificateNote { get; set; } = null!;

    public int Pin { get; set; }

    public bool CanExpire { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public int ExpirationDurationCount { get; set; }

    public string? ExpirationDurationType { get; set; }

    public DateOnly RecognizedDate { get; set; }

    public bool SharedWithLinked { get; set; }

    public bool? Status { get; set; }

    /// <summary>
    /// Sold By
    /// </summary>
    public int SoldBy { get; set; }

    /// <summary>
    /// Liability Accounting Group Id
    /// </summary>
    public int? LiabilityAccountingGroupId { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public bool Portal { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual GiftCertificateType? CertificateType { get; set; }
}
