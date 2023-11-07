using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// List of availible paiment types for custom refund
/// </summary>
public partial class RefundCustomRefundType
{
    public int Id { get; set; }

    public int? PaymenttypeId { get; set; }

    public int? Status { get; set; }

    public string? Comment { get; set; }

    public decimal? RefundThreshold { get; set; }

    public string? RefundNotificationEmails { get; set; }

    public virtual PaymentType? Paymenttype { get; set; }
}
