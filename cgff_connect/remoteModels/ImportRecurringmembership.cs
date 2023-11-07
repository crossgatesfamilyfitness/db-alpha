using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportRecurringmembership
{
    public uint InternalId { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    public string AccountNumber { get; set; } = null!;

    /// <summary>
    /// Must be a valid AccountNumber
    /// </summary>
    public string MembershipName { get; set; } = null!;

    public string? MembershipStatus { get; set; }

    /// <summary>
    /// Fee
    /// </summary>
    public decimal Fee { get; set; }

    /// <summary>
    /// RenewalFee
    /// </summary>
    public decimal RenewalFee { get; set; }

    public string? ContractStartDate { get; set; }

    public string? ContractEndDate { get; set; }

    public string? NextTransactionDate { get; set; }

    public string? JoinDate { get; set; }

    public string? ExpireDate { get; set; }

    /// <summary>
    /// OnHoldFee
    /// </summary>
    public decimal OnHoldFee { get; set; }

    public string? HoldFromDate { get; set; }

    public string? HoldToDate { get; set; }

    public string? FreezeStartDate { get; set; }

    public string? FreezeEndDate { get; set; }

    public string? CanceledDate { get; set; }

    public int? BillingDay { get; set; }

    public int? NumberOfPaidCycles { get; set; }

    public string? MembershipIdentifier { get; set; }

    public string? CancelOnDate { get; set; }

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

    public virtual ImportProfile AccountNumberNavigation { get; set; } = null!;

    public virtual ImportRecurringusergroup MembershipNameNavigation { get; set; } = null!;
}
