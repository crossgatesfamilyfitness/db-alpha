using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CourtLocationComponent
{
    public int Id { get; set; }

    public int CourtLocationId { get; set; }

    public int ComponentId { get; set; }

    public virtual Component Component { get; set; } = null!;

    public virtual CourtLocation CourtLocation { get; set; } = null!;
}
