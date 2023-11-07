using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CcTransaction
{
    public ulong Id { get; set; }

    public uint UserId { get; set; }

    public string Result { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime Time { get; set; }

    public decimal Total { get; set; }

    public string? CreditCardNumber { get; set; }

    public string? CcTransactionInfo { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public bool RetailerId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
