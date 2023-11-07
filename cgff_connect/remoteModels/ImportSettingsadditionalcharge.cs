using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportSettingsadditionalcharge
{
    public uint InternalId { get; set; }

    /// <summary>
    /// Required - Must match Name from &apos;usergroup.csv&apos; file
    /// </summary>
    public string UserGroupName { get; set; } = null!;

    /// <summary>
    /// Description of charge
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Fee
    /// </summary>
    public decimal Fee { get; set; }

    /// <summary>
    /// Accounting Group
    /// </summary>
    public short? AccountingGroup { get; set; }

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
