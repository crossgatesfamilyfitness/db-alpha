using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChargePaymentPending
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Charge ID
    /// </summary>
    public ulong ChargeId { get; set; }

    /// <summary>
    /// Payment ID
    /// </summary>
    public ulong PaymentId { get; set; }
}
