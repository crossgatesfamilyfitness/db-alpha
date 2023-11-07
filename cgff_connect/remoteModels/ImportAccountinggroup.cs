using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportAccountinggroup
{
    public uint InternalId { get; set; }

    /// <summary>
    /// Must be a unique name that is not used by another accounting group
    /// </summary>
    public string UniqueName { get; set; } = null!;

    /// <summary>
    /// Title
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// DefaultTransactionDescription
    /// </summary>
    public string? DefaultTransactionDescription { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? DisplayCustomDescriptionFieldInPos { get; set; }

    /// <summary>
    /// must match an id from clubautomation tbl shop_tax_rate
    /// </summary>
    public int? Tax { get; set; }

    /// <summary>
    /// must match an existing group
    /// </summary>
    public string? ParentGroup { get; set; }

    /// <summary>
    /// Entity
    /// </summary>
    public string? Entity { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? NotAvailableInPos { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? NotAvailableForStatementCharges { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? CanBeDiscounted { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? CanAddSoldByInPos { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? Cogs { get; set; }

    /// <summary>
    /// enum(&apos;Revenue&apos;,&apos;Liability&apos;)
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// csv line number that corresponds to this row
    /// </summary>
    public int CsvLineNo { get; set; }

    /// <summary>
    /// unique id from the row inserted to ca production db
    /// </summary>
    public int? CaId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }
}
