using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserContractToUserGroupSubscription
{
    public int Id { get; set; }

    public int? UserContractId { get; set; }

    public int? UserGroupSubscriptionId { get; set; }

    public string AuditStatus { get; set; } = null!;

    public DateTime? AgreementStartDate { get; set; }

    public DateTime? AgreementEndDate { get; set; }

    public decimal? TotalAgreementAmount { get; set; }

    public DateTime? CancellationDate { get; set; }

    public DateTime? FirstBillingDate { get; set; }

    public decimal BaseFee { get; set; }

    public string? CycleRenewType { get; set; }
}
