using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BlockedCreditCard
{
    public int Id { get; set; }

    public string Gateway { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string PaymentProcessorUniqueId { get; set; } = null!;

    public string? Description { get; set; }

    public string GatewayResponse { get; set; } = null!;

    public string? Error { get; set; }

    public DateTime SubmissionStartDate { get; set; }

    public DateTime SubmissionEndDate { get; set; }

    public int SubmissionAttemptsCount { get; set; }
}
