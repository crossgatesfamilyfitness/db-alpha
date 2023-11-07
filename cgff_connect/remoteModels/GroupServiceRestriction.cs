using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupServiceRestriction
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ServiceId { get; set; }

    public int? EntityId { get; set; }
}
