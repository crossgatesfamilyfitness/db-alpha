using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GiftCertificateAccountingGroup
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Certificate Type Id
    /// </summary>
    public int CertificateTypeId { get; set; }

    /// <summary>
    /// Accgroup Entity Id
    /// </summary>
    public int? EntityId { get; set; }

    /// <summary>
    /// Liability Accounting Group Id
    /// </summary>
    public int? LiabilityAccountingGroupId { get; set; }

    public virtual GiftCertificateType CertificateType { get; set; } = null!;

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual AccountingGroup? LiabilityAccountingGroup { get; set; }
}
