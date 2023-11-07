using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GiftCertificateRestriction
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Certificate Type Id
    /// </summary>
    public int? CertificateTypeId { get; set; }

    /// <summary>
    /// Accounting Group Id
    /// </summary>
    public int? AccountingGroupId { get; set; }

    public virtual AccountingGroup? AccountingGroup { get; set; }

    public virtual GiftCertificateType? CertificateType { get; set; }
}
