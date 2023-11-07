using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EquipmentCheckin
{
    public ulong Id { get; set; }

    public int ItemId { get; set; }

    public int UserId { get; set; }

    public float Price { get; set; }

    public float LateFee { get; set; }

    public DateTime CheckIn { get; set; }

    public DateTime CheckOut { get; set; }

    public string Status { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }
}
