using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Transactionlog
{
    public int Id { get; set; }

    public string? Comment { get; set; }

    public string? TableName { get; set; }

    public string? Action { get; set; }

    public string? Status { get; set; }

    public DateTime EffectiveDate { get; set; }

    public int? RowsAffected { get; set; }

    public string? SourceOfSync { get; set; }
}
