using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineRegistrationRule
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public bool? Type { get; set; }

    public int Group { get; set; }

    public int Season { get; set; }

    public string RestrictionDescr { get; set; } = null!;

    public int? EntityId { get; set; }
}
