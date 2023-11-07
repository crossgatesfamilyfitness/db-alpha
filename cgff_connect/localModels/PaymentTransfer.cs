using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class PaymentTransfer
{
    public long Id { get; set; }

    /// <summary>
    /// date of the transfer
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// user who paid
    /// </summary>
    public int FromUserId { get; set; }

    /// <summary>
    /// user who had the charge
    /// </summary>
    public int ToUserId { get; set; }

    /// <summary>
    /// original payment
    /// </summary>
    public ulong FromPaymentId { get; set; }

    /// <summary>
    /// applied credit
    /// </summary>
    public ulong ToPaymentId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public int ModifiedByIntranet { get; set; }

    public string? LastTrack { get; set; }
}
