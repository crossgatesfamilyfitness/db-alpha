using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class NoteSetting
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Enabled { get; set; }
}
