using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GiftCertificateType
{
    /// <summary>
    /// id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Type Name
    /// </summary>
    public string TypeName { get; set; } = null!;

    /// <summary>
    /// Available For Sale
    /// </summary>
    public bool Status { get; set; }

    /// <summary>
    /// Share With Linked
    /// </summary>
    public bool ShareWithLinked { get; set; }

    /// <summary>
    /// Default Share
    /// </summary>
    public bool DefaultShare { get; set; }

    /// <summary>
    /// Can Expire
    /// </summary>
    public bool CanExpire { get; set; }

    /// <summary>
    /// Expiration Date
    /// </summary>
    public DateOnly? ExpirationDate { get; set; }

    /// <summary>
    /// Expiration Duration Count
    /// </summary>
    public int? ExpirationDurationCount { get; set; }

    /// <summary>
    /// Expiration Duration Type
    /// </summary>
    public string? ExpirationDurationType { get; set; }

    public bool IsAllStaffGroupsCanSell { get; set; }

    public bool IsAvailableOnline { get; set; }

    public string? Denomination { get; set; }

    public string OnlineDescription { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }

    public virtual ICollection<GiftCertificateAccountingGroup> GiftCertificateAccountingGroups { get; } = new List<GiftCertificateAccountingGroup>();

    public virtual ICollection<GiftCertificateEntity> GiftCertificateEntities { get; } = new List<GiftCertificateEntity>();

    public virtual ICollection<GiftCertificateRestriction> GiftCertificateRestrictions { get; } = new List<GiftCertificateRestriction>();

    public virtual ICollection<GiftCertificateSaleEntity> GiftCertificateSaleEntities { get; } = new List<GiftCertificateSaleEntity>();

    public virtual ICollection<GiftCertificate> GiftCertificates { get; } = new List<GiftCertificate>();
}
