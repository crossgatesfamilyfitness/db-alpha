using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ResourceScheduleInfo
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Description { get; set; }
}
