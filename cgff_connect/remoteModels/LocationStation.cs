using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LocationStation
{
    public int Id { get; set; }

    public int? RoomId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual LocationRoom? Room { get; set; }
}
