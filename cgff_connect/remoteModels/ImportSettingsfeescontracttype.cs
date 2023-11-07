using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportSettingsfeescontracttype
{
    public uint InternalId { get; set; }

    /// <summary>
    /// Required - Must match Name from &apos;usergroup.csv&apos; file
    /// </summary>
    public string UserGroupName { get; set; } = null!;

    /// <summary>
    /// Required - Only Valid For Interval Billing Types - enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string AutoRenew { get; set; } = null!;

    /// <summary>
    /// *Required - enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string DoNotExpireIfUnpaid { get; set; } = null!;

    /// <summary>
    /// Only Valid for monthly Billing Types - enum(&apos;No Charge&apos;,&apos;Charge&apos;,&apos;Credit&apos;,&apos;&apos;)
    /// </summary>
    public string? HoldOptions { get; set; }

    /// <summary>
    /// Default Hold Fee
    /// </summary>
    public decimal DefaultHoldFee { get; set; }

    /// <summary>
    /// Contract Fee
    /// </summary>
    public decimal ContractFee { get; set; }

    /// <summary>
    /// Membership Renewal Fee
    /// </summary>
    public decimal MembershipRenewalFee { get; set; }

    /// <summary>
    /// EnrollmentFee
    /// </summary>
    public decimal EnrollmentFee { get; set; }

    /// <summary>
    /// Required - enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string AutoCancel { get; set; } = null!;

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string Contract { get; set; } = null!;

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string AvailableForSale { get; set; } = null!;

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string LockRate { get; set; } = null!;

    /// <summary>
    /// Only valid for Interval Billing Types - enum(&apos;0&apos;,&apos;1&apos;)
    /// </summary>
    public short AutoRenewDaysBeforeReactivation { get; set; }

    /// <summary>
    /// Text String - must match an existing contract terms name
    /// </summary>
    public string? ContractTerms { get; set; }

    /// <summary>
    /// Contract Duration
    /// </summary>
    public string? ContractDuration { get; set; }

    /// <summary>
    /// enum(&apos;Terminate on Expiration&apos;,&apos;Automatically Renew&apos;,&apos;Renew without Contract&apos;,&apos;Month to Month&apos;)
    /// </summary>
    public string ContractRenewalOptions { get; set; } = null!;

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

    public virtual ImportRecurringusergroup UserGroupNameNavigation { get; set; } = null!;
}
