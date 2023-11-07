using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Tournament
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? RegisterDeadline { get; set; }

    public uint? EventId { get; set; }
}
