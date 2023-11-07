using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportRecurringusergroup
{
    /// <summary>
    /// Required
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Required - enum(&apos;membership&apos;,&apos;addon&apos;,&apos;staff&apos;,&apos;guest&apos;)
    /// </summary>
    public string UserGroupType { get; set; } = null!;

    /// <summary>
    /// Required - enum(&apos;individual&apos;,&apos;family&apos;)
    /// </summary>
    public string FamilyType { get; set; } = null!;

    /// <summary>
    /// Required - enum(&apos;pif&apos;,&apos;recurring&apos;)
    /// </summary>
    public string BillingType { get; set; } = null!;

    public int CycleLength { get; set; }

    /// <summary>
    /// enum(&apos;day&apos;,&apos;week&apos;,&apos;month&apos;,&apos;year&apos;)
    /// </summary>
    public string CycleLengthType { get; set; } = null!;

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    /// <summary>
    /// csv line number that corresponds to this row
    /// </summary>
    public int CsvLineNo { get; set; }

    /// <summary>
    /// unique id from the row inserted to ca production db
    /// </summary>
    public int? CaId { get; set; }

    public virtual ICollection<ImportRecurringmembership> ImportRecurringmemberships { get; } = new List<ImportRecurringmembership>();

    public virtual ICollection<ImportSettingsadditionalcharge> ImportSettingsadditionalcharges { get; } = new List<ImportSettingsadditionalcharge>();

    public virtual ICollection<ImportSettingsfeescontracttype> ImportSettingsfeescontracttypes { get; } = new List<ImportSettingsfeescontracttype>();
}
