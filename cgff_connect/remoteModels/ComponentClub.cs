using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ComponentClub
{
    public int Id { get; set; }

    public int ComponentId { get; set; }

    public string Name { get; set; } = null!;

    public int ContentItemId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
