using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Session
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Expired { get; set; }

    public uint UserId { get; set; }
}
