using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Programm
{
    public int Id { get; set; }

    public uint CreatorId { get; set; }

    public int ComponentId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ApprovedList { get; set; } = null!;
}
