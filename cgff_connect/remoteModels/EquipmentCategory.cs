using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EquipmentCategory
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string Name { get; set; } = null!;

    public bool UseDefaults { get; set; }

    public string DueType { get; set; } = null!;

    public int InAmountDays { get; set; }

    public TimeOnly DueTime { get; set; }

    public int EntityId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
