using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AccgroupEntity
{
    public int Id { get; set; }

    public string EntityName { get; set; } = null!;

    public bool CcRetailer { get; set; }

    public bool Default { get; set; }

    public string DefaultLocation { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public string GlCode { get; set; } = null!;

    public string? AccGroupName { get; set; }

    public string? TimeZone { get; set; }

    public string Address { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string MailAddress { get; set; } = null!;

    public string MailAddress2 { get; set; } = null!;

    public string MailCity { get; set; } = null!;

    public string MailState { get; set; } = null!;

    public string MailCountry { get; set; } = null!;

    public string MailZip { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    /// <summary>
    /// Is this entity visible online
    /// </summary>
    public sbyte OnlineIsVisible { get; set; }

    /// <summary>
    /// Member-facing location name. If blank entity_name will be used
    /// </summary>
    public string OnlineName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public int AllowedCapacity { get; set; }

    public virtual ICollection<ComponentEntity> ComponentEntities { get; } = new List<ComponentEntity>();

    public virtual ICollection<GiftCertificateAccountingGroup> GiftCertificateAccountingGroups { get; } = new List<GiftCertificateAccountingGroup>();

    public virtual ICollection<GiftCertificateEntity> GiftCertificateEntities { get; } = new List<GiftCertificateEntity>();

    public virtual ICollection<GiftCertificateSaleEntity> GiftCertificateSaleEntities { get; } = new List<GiftCertificateSaleEntity>();

    public virtual ICollection<LocationArea> LocationAreas { get; } = new List<LocationArea>();

    public virtual ICollection<LocationSchedule> LocationSchedules { get; } = new List<LocationSchedule>();

    public virtual ICollection<ServiceAccountingGroup> ServiceAccountingGroups { get; } = new List<ServiceAccountingGroup>();

    public virtual ICollection<ServiceAlternateFee> ServiceAlternateFees { get; } = new List<ServiceAlternateFee>();

    public virtual ICollection<ServiceCommission> ServiceCommissions { get; } = new List<ServiceCommission>();

    public virtual ICollection<ServiceFee> ServiceFees { get; } = new List<ServiceFee>();

    public virtual ICollection<StaffSchedule> StaffSchedules { get; } = new List<StaffSchedule>();
}
