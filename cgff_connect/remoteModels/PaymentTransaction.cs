using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PaymentTransaction
{
    public ulong Id { get; set; }

    public ulong? TransactionId { get; set; }

    public int Number { get; set; }

    public int TypeId { get; set; }

    public int UserId { get; set; }

    public uint PayerId { get; set; }

    public uint AddedBy { get; set; }

    public DateOnly Date { get; set; }

    public DateTime Time { get; set; }

    public float Amount { get; set; }

    public float OriginalAmount { get; set; }

    public float CreditAmount { get; set; }

    public string? Description { get; set; }

    public string? OriginalDescription { get; set; }

    public long CcTransactionId { get; set; }

    public int CheckId { get; set; }

    public int CertificateId { get; set; }

    public uint UpackageId { get; set; }

    public sbyte HasPrevId { get; set; }

    public long PackageChId { get; set; }

    public short PMode { get; set; }

    public short TransactionType { get; set; }

    public bool VirtualCash { get; set; }

    public bool IsEft { get; set; }

    public int PosId { get; set; }

    public int ShiftId { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public sbyte IsPosted { get; set; }

    public DateOnly? PostedDate { get; set; }

    public sbyte Pstatus { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
