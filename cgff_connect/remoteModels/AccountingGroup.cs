using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AccountingGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string UseDescription { get; set; } = null!;

    public short? ComponentId { get; set; }

    public sbyte? Taxable { get; set; }

    public int TaxRateId { get; set; }

    public uint BuiltIn { get; set; }

    public bool IsDescription { get; set; }

    public bool IsInvisible { get; set; }

    public bool InvisibleForPos { get; set; }

    public bool NoCustomCharge { get; set; }

    public sbyte Discountable { get; set; }

    public int ParentId { get; set; }

    public bool QbInventory { get; set; }

    public int CogsAcct { get; set; }

    public int RevenueAcct { get; set; }

    public int EntityId { get; set; }

    public string? GlCode { get; set; }

    public sbyte Acctype { get; set; }

    public string Params { get; set; } = null!;

    public sbyte LiabilityType { get; set; }

    public bool IsDisabled { get; set; }

    public bool IsUnavailable { get; set; }

    public bool HideInFilter { get; set; }

    public sbyte ExpRecognition { get; set; }

    public sbyte CanAddSoldBy { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual ICollection<AddonDiscount> AddonDiscounts { get; } = new List<AddonDiscount>();

    public virtual ICollection<GiftCertificateAccountingGroup> GiftCertificateAccountingGroups { get; } = new List<GiftCertificateAccountingGroup>();

    public virtual ICollection<GiftCertificateRestriction> GiftCertificateRestrictions { get; } = new List<GiftCertificateRestriction>();

    public virtual ICollection<ServiceAccountingGroup> ServiceAccountingGroups { get; } = new List<ServiceAccountingGroup>();

    public virtual ICollection<ServiceAlternateFee> ServiceAlternateFees { get; } = new List<ServiceAlternateFee>();
}
