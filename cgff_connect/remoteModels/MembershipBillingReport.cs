using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MembershipBillingReport
{
    public int Id { get; set; }

    /// <summary>
    /// The date and time when the row was generated
    /// </summary>
    public DateTime GeneratedDate { get; set; }

    /// <summary>
    /// Billing period (date)
    /// </summary>
    public string Period { get; set; } = null!;

    /// <summary>
    /// Whether the item was already billed till generated_date
    /// </summary>
    public bool Billed { get; set; }

    /// <summary>
    /// Data source
    /// </summary>
    public short Source { get; set; }

    /// <summary>
    /// Charge Mode
    /// </summary>
    public short? ChargeMode { get; set; }

    public int GroupId { get; set; }

    public int UserId { get; set; }

    /// <summary>
    /// Added By User ID
    /// </summary>
    public int AddedBy { get; set; }

    /// <summary>
    /// Billed By User ID
    /// </summary>
    public int BilledBy { get; set; }

    public string FeeType { get; set; } = null!;

    /// <summary>
    /// Final Charge Price or Total Payment Amount
    /// </summary>
    public decimal CurrentAmount { get; set; }

    /// <summary>
    /// Original Charge Price or Total Payment Amount
    /// </summary>
    public decimal OriginalAmount { get; set; }

    /// <summary>
    /// Charge Bill Date or Payment Date Index
    /// </summary>
    public DateTime BillDate { get; set; }

    /// <summary>
    /// Charge Invoice Date or Payment Date Index
    /// </summary>
    public DateTime InvoiceDate { get; set; }

    public ulong InvoiceId { get; set; }

    /// <summary>
    /// Charge Report Date or Payment Date Index
    /// </summary>
    public DateTime AccountingDate { get; set; }

    public bool? CacheStatus { get; set; }
}
