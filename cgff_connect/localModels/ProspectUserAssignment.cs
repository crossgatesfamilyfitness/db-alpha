using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ProspectUserAssignment
{
    public uint Id { get; set; }

    public uint ProspectUserId { get; set; }

    public uint AssignedToId { get; set; }

    public uint AssignedToIdSecondary { get; set; }
}
