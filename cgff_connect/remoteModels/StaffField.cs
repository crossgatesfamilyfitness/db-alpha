using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffField
{
    public int Id { get; set; }

    public int ComponentId { get; set; }

    public int StaffId { get; set; }

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string StaffLevel { get; set; } = null!;

    public int LessonType { get; set; }

    public sbyte PlayerOnCourt { get; set; }

    public string FeeName { get; set; } = null!;

    public int LocationId { get; set; }

    public int BillingRatePeriod { get; set; }

    public decimal Rate { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
