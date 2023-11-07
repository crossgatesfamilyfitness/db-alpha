using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserContractToUserPackage
{
    public int Id { get; set; }

    public int? UserContractId { get; set; }

    public int? UserPackageId { get; set; }

    public string AuditStatus { get; set; } = null!;

    public decimal? TotalAgreementAmount { get; set; }
}
