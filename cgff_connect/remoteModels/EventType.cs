using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ServiceType> ServiceTypes { get; } = new List<ServiceType>();
}
