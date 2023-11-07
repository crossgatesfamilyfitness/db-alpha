using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RefundReceipt
{
    /// <summary>
    /// Refunding Receipt ID
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Refunding receipt date
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// receipt.ids json
    /// </summary>
    public string? ReceiptIds { get; set; }
}
