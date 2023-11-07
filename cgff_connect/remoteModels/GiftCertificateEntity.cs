using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GiftCertificateEntity
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
    /// Accgroup Entity Id
    /// </summary>
    public int? EntityId { get; set; }

    public virtual GiftCertificateType? CertificateType { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }
}
