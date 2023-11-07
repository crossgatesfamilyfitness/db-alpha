using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaAddon
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public uint ServiceId { get; set; }

    public sbyte Archived { get; set; }

    public int AccountingGroupId { get; set; }

    public sbyte BilledByTime { get; set; }

    public decimal Price { get; set; }
}
