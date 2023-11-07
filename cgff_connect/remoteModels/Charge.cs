using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Charge
{
    public ulong Id { get; set; }

    public uint AddedBy { get; set; }

    public int UserId { get; set; }

    public uint Vendor { get; set; }

    public long UserFor { get; set; }

    public int PlayerNum { get; set; }

    public int? AccountingGroupId { get; set; }

    /// <summary>
    /// club id taken from accounting group id
    /// </summary>
    public int? EntityId { get; set; }

    /// <summary>
    /// club id taken from user profile
    /// </summary>
    public int UserHomeClub { get; set; }

    public uint SubjectId { get; set; }

    public ulong ScheduleId { get; set; }

    public ulong EventId { get; set; }

    public DateOnly? EventDate { get; set; }

    public int? ItemId { get; set; }

    public decimal Count { get; set; }

    public decimal ReturnedCount { get; set; }

    public decimal PricePerUnit { get; set; }

    public decimal PriceFinal { get; set; }

    /// <summary>
    /// Price when charge was created, immutable
    /// </summary>
    public decimal OriginalPrice { get; set; }

    public decimal CostPerUnit { get; set; }

    public decimal CostFinal { get; set; }

    public decimal TotalPaid { get; set; }

    public decimal TotalReversed { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalDescription { get; set; }

    public string? CustomDescription { get; set; }

    public DateTime DescriptionDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    /// <summary>
    /// Data when charge was created, immutable
    /// </summary>
    public DateTime BillDate { get; set; }

    public DateTime InvoiceTime { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public DateOnly? ReportDate { get; set; }

    public DateTime? CustomTime { get; set; }

    public DateTime? CancellationDate { get; set; }

    public bool CancellationCharge { get; set; }

    public string? Status { get; set; }

    public string Type { get; set; } = null!;

    public short Mode { get; set; }

    public bool Used { get; set; }

    public decimal TaxRate { get; set; }

    public decimal ClubTaxRate { get; set; }

    public int TaxRateId { get; set; }

    public decimal? Tax { get; set; }

    public decimal DiscountRate { get; set; }

    public decimal Discount { get; set; }

    public string RefundHistory { get; set; } = null!;

    public bool PaidOff { get; set; }

    public bool ExportToQb { get; set; }

    public long EftId { get; set; }

    public decimal EftAmount { get; set; }

    public bool Removable { get; set; }

    public sbyte EventStatus { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public sbyte IsAutomatic { get; set; }

    public bool Hide { get; set; }

    public bool Unreal { get; set; }

    public int PosId { get; set; }

    public int ShiftId { get; set; }

    public sbyte Finalized { get; set; }

    public sbyte IsPosted { get; set; }

    public DateOnly? PostedDate { get; set; }

    public sbyte IsOnline { get; set; }

    public string ForeignId { get; set; } = null!;

    public string ForeignText { get; set; } = null!;

    public int? SoldBy { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual ICollection<UserContractCharge> UserContractCharges { get; } = new List<UserContractCharge>();
}
