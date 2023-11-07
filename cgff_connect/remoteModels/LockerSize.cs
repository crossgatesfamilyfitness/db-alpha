using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LockerSize
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public int AccGroup { get; set; }

    /// <summary>
    /// club id
    /// </summary>
    public int? EntityId { get; set; }
}
