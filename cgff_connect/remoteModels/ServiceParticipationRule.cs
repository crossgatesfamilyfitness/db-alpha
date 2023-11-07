using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceParticipationRule
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public int MinParticipants { get; set; }

    public int MaxParticipants { get; set; }

    public int MinStaff { get; set; }

    public int MaxStaff { get; set; }

    public int MinAge { get; set; }

    public int MaxAge { get; set; }

    public virtual ServiceType? ServiceType { get; set; }
}
