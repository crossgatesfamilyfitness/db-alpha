using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaService
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public uint ParentId { get; set; }

    public int SuggestedTime { get; set; }

    public ushort SortOrder { get; set; }

    public sbyte Archived { get; set; }

    public int AccountingGroupId { get; set; }

    public sbyte BilledByTime { get; set; }

    public decimal Price { get; set; }
}
