using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class BatchConfigure
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public int? UpdateFrequencyMinutes { get; set; }

    public string? UpdateColumnName { get; set; }

    public string? IdColumnName { get; set; }
}
