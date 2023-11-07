using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Menu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public int ParentId { get; set; }

    public int Ordering { get; set; }
}
