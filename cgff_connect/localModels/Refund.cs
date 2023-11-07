using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Refund
{
    public int Id { get; set; }

    public ulong PaymentId { get; set; }

    public int PaymentType { get; set; }

    public float Amount { get; set; }

    public float TotalAmount { get; set; }

    public DateTime Date { get; set; }

    public DateOnly DateIndex { get; set; }

    public string Type { get; set; } = null!;

    /// <summary>
    /// export to qb even if charge.export_to_qb=0
    /// </summary>
    public bool ExportToQb { get; set; }

    public long ChargeId { get; set; }

    public int RefundReceiptId { get; set; }

    public string? CcNumber { get; set; }

    public int? CheckId { get; set; }

    public int? CertificateId { get; set; }

    public bool IsCustom { get; set; }

    public int PosId { get; set; }

    public int ShiftId { get; set; }

    /// <summary>
    /// club id
    /// </summary>
    public int EntityId { get; set; }

    public sbyte IsPosted { get; set; }

    public DateOnly? PostedDate { get; set; }

    public uint AddedBy { get; set; }
}
