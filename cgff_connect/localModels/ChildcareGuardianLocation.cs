using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ChildcareGuardianLocation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public sbyte? EntityId { get; set; }

    public sbyte Status { get; set; }
}
