using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserMetricValue
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int MetricId { get; set; }

    public string Value { get; set; } = null!;

    public DateOnly CreateDate { get; set; }
}
