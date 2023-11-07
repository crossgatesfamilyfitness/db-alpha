using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Mailgroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public uint OwnerId { get; set; }

    public string Type { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int ParentId { get; set; }
}
