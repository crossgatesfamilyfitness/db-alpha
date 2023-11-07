using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GiftCertificateStaffRestriction
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
    /// Group ID
    /// </summary>
    public int GroupId { get; set; }
}
