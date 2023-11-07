using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ProspectUserTask
{
    public uint Id { get; set; }

    public uint ProspectUserId { get; set; }

    public uint ProspectTaskId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly? TimeStart { get; set; }

    public TimeOnly? TimeEnd { get; set; }

    public string? Status { get; set; }

    public DateTime? CompletedTime { get; set; }

    public uint AssignedToId { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public int? EventId { get; set; }

    public uint? ProspectOptionId { get; set; }
}
