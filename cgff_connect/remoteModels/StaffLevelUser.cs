using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffLevelUser
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? StaffLevelId { get; set; }

    public int? ComponentId { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual Component? Component { get; set; }

    public virtual StaffLevel? StaffLevel { get; set; }

    public virtual User? User { get; set; }
}
