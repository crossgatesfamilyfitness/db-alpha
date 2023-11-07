using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventCustomDate
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public DateTime DateOpenAsOf { get; set; }

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
