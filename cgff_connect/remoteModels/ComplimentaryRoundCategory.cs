using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ComplimentaryRoundCategory
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public sbyte Status { get; set; }
}
