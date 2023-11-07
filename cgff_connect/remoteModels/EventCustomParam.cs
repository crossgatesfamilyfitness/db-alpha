using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventCustomParam
{
    public int Id { get; set; }

    public uint EventId { get; set; }

    public string? Type { get; set; }

    public DateTime DateOpenAsOf { get; set; }

    public int? OnlineRegOpenValue { get; set; }

    public string OnlineRegOpenPeriod { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
