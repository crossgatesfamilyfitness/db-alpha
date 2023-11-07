using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Transaction
{
    public ulong Id { get; set; }

    public int UserId { get; set; }

    public string Result { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime Time { get; set; }

    public DateOnly Date { get; set; }

    public decimal Subtotal { get; set; }

    public decimal TaxRate { get; set; }

    public decimal Tax { get; set; }

    public decimal Discount { get; set; }

    public decimal Total { get; set; }

    public float ChangeGiven { get; set; }

    public bool MailBilled { get; set; }

    public string? CreditCardNumber { get; set; }

    public string? AuthorizationNumber { get; set; }

    public string SslTxnId { get; set; } = null!;

    public string SslApprovalCode { get; set; } = null!;

    public string CcTransactionInfo { get; set; } = null!;

    public bool IsEft { get; set; }

    public bool IsCheck { get; set; }

    public string? EftCode { get; set; }

    public bool? Complete { get; set; }

    public DateTime EftDate { get; set; }

    public string SubmitStatus { get; set; } = null!;

    public bool Unreal { get; set; }

    public int PosId { get; set; }

    public int ShiftId { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public bool RetailerId { get; set; }

    public string TParams { get; set; } = null!;

    /// <summary>
    /// club id
    /// </summary>
    public int EntityId { get; set; }

    public sbyte IsOnline { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
