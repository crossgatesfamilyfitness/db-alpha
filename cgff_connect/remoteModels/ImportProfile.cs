using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportProfile
{
    /// <summary>
    /// Required
    /// </summary>
    public string AccountNumber { get; set; } = null!;

    /// <summary>
    /// Must be a valid AccountNumber
    /// </summary>
    public string? PrimaryAccountNumber { get; set; }

    public string? MemberNumber { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? AccessCard { get; set; }

    public string? StreetAddress { get; set; }

    public string? StreetAddress2 { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Birthday { get; set; }

    /// <summary>
    /// Empty value will be converted to &apos;not set&apos; - Not empty not allowed value will be converted to &apos;male&apos;
    /// </summary>
    public string Sex { get; set; } = null!;

    public string? Email { get; set; }

    public string? PhoneHome { get; set; }

    public string? PhoneCell { get; set; }

    public string? PhoneWork { get; set; }

    public string? PhoneEmergency { get; set; }

    public string? EmergencyContact { get; set; }

    public string? EmergencyRelation { get; set; }

    /// <summary>
    /// enum(&apos;no&apos;,&apos;credit card&apos;, &apos;bank account&apos;, &apos;mail bill&apos;) - Not set or not allowed value will be converted to &apos;no&apos;
    /// </summary>
    public string EftpaymentMethod { get; set; } = null!;

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;) - Not set or not allowed value will be converted to &apos;no&apos;
    /// </summary>
    public string HouseCharge { get; set; } = null!;

    /// <summary>
    /// enum(&apos;none&apos;,&apos;email&apos;,&apos;mail&apos;) - Not set or not allowed value will be converted to &apos;no&apos;
    /// </summary>
    public string DeliveryMethod { get; set; } = null!;

    public int EntityId { get; set; }

    /// <summary>
    /// credit limit
    /// </summary>
    public int CreditLimit { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string TaxExempt { get; set; } = null!;

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string LateFeeExempt { get; set; } = null!;

    /// <summary>
    /// enum(&apos;0&apos;,&apos;1&apos;)
    /// </summary>
    public short IsProspect { get; set; }

    public string? ProspectOpenDate { get; set; }

    public string? ProspectConfidence { get; set; }

    public string? ProspectAssignedTo { get; set; }

    public string? ProspectAssignedTo2 { get; set; }

    public DateTime? DateCreated { get; set; }

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

    public virtual ICollection<ImportRecurringmembership> ImportRecurringmemberships { get; } = new List<ImportRecurringmembership>();
}
