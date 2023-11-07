using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class GiftCertificate
{
    public ulong Id { get; set; }

    public string? LogTransactionId { get; set; }

    public string Type { get; set; } = null!;

    public uint ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string UpdatedColumns { get; set; } = null!;

    public string OldValues { get; set; } = null!;

    public string NewValues { get; set; } = null!;

    public string Track { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public uint GiftcertificateId { get; set; }

    public uint? Receiver { get; set; }

    public byte Status { get; set; }

    public decimal Amount { get; set; }

    public decimal OriginalAmount { get; set; }

    public decimal RefundedAmount { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public byte SharedWithLinked { get; set; }

    public int EntityId { get; set; }
}
