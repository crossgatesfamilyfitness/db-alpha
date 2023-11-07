using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventPro
{
    public int EventId { get; set; }

    public int StaffId { get; set; }

    public DateOnly Date { get; set; }

    public string? PayrollRates { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
