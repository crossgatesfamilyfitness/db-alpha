using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MemberCart
{
    public ulong Id { get; set; }

    public int AuthId { get; set; }

    public int UserId { get; set; }

    public ulong? ItemId { get; set; }

    public sbyte ItemType { get; set; }

    public decimal Amount { get; set; }

    public decimal PricePerUnit { get; set; }

    public decimal DiscountRate { get; set; }

    public float DiscountAmount { get; set; }

    public bool DiscountAppliedWithAsterisk { get; set; }

    public bool DiscountAppliedWithPackage { get; set; }

    public uint AppliedPackageId { get; set; }

    public bool? TryReallocatePackage { get; set; }

    public bool? ReallocatePackage { get; set; }

    public decimal PriceFinal { get; set; }

    public string? AllDiscountRates { get; set; }

    public sbyte Status { get; set; }

    public string Description { get; set; } = null!;

    public string CancelReason { get; set; } = null!;

    public bool Removable { get; set; }

    public string? Params { get; set; }

    public DateOnly DateAdded { get; set; }

    public DateTime TimeAdded { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public float Tax { get; set; }

    public int TaxRateId { get; set; }

    public DateTime? ReserveExpirationDate { get; set; }

    public ulong? ChargeId { get; set; }

    public byte CartType { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
