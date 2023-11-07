using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Payment
{
    public ulong Id { get; set; }

    public ulong? ChargeId { get; set; }

    public int AccGroupId { get; set; }

    public int? ShopCartId { get; set; }

    public int TypeId { get; set; }

    public int UserId { get; set; }

    public uint PayerId { get; set; }

    public long UserFor { get; set; }

    public uint AddedBy { get; set; }

    public DateTime Date { get; set; }

    public DateOnly DateIndex { get; set; }

    public decimal Amount { get; set; }

    public decimal AmountTotal { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal TaxReversed { get; set; }

    public decimal TaxReversedRate { get; set; }

    public int TaxReversedId { get; set; }

    public decimal AmountReturned { get; set; }

    public string Description { get; set; } = null!;

    public bool VirtualCash { get; set; }

    public int? CheckId { get; set; }

    public uint UpackageId { get; set; }

    public long PackageChId { get; set; }

    public decimal Discount { get; set; }

    public ulong? TransactionId { get; set; }

    public ulong PtransactionId { get; set; }

    public sbyte Pstatus { get; set; }

    public bool IsEft { get; set; }

    public decimal PaidBefore { get; set; }

    public decimal PaidToday { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public long PEventId { get; set; }

    public int PScheduleId { get; set; }

    public int PResourceId { get; set; }

    public DateOnly? EventDate { get; set; }

    public int? ItemId { get; set; }

    public short PMode { get; set; }

    public int SellId { get; set; }

    public int CertificateId { get; set; }

    public long PrevId { get; set; }

    public string PrevData { get; set; } = null!;

    public long CcTransactionId { get; set; }

    public bool IsAdjustment { get; set; }

    public long PfId { get; set; }

    public ulong PfChargeId { get; set; }

    public int PfAccGroup { get; set; }

    public int PfTypeId { get; set; }

    public int RefundId { get; set; }

    public bool Hide { get; set; }

    public bool Unreal { get; set; }

    public bool Voided { get; set; }

    public DateTime? VoidedTime { get; set; }

    public DateOnly? VoidedDate { get; set; }

    public int PosId { get; set; }

    public int ShiftId { get; set; }

    public bool DepositPayment { get; set; }

    /// <summary>
    /// club id
    /// </summary>
    public int EntityId { get; set; }

    /// <summary>
    /// club id taken from user profile
    /// </summary>
    public int UserHomeClub { get; set; }

    public int FromEntityId { get; set; }

    public sbyte IsPosted { get; set; }

    public DateOnly? PostedDate { get; set; }

    public sbyte IsOnline { get; set; }

    public sbyte EventStatus { get; set; }

    public string ForeignId { get; set; } = null!;

    public string ForeignText { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
