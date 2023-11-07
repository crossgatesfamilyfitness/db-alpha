using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Dict
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
