using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GiftCertificateRestrictionsEntity
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gift Certificate Type ID
    /// </summary>
    public int GiftCertificateTypeId { get; set; }

    /// <summary>
    /// Accounting Group Entity ID
    /// </summary>
    public int AccgroupEntityId { get; set; }
}
