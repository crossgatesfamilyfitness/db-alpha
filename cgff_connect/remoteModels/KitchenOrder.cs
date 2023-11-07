using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class KitchenOrder
{
    public uint Id { get; set; }

    public long TransactionId { get; set; }

    public string Status { get; set; } = null!;

    public int CustomerId { get; set; }

    public int TableNumber { get; set; }

    public DateTime Timestamp { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int StaffMemberId { get; set; }

    public bool Pickup { get; set; }

    public string? Delivery { get; set; }

    public string? OrderNotes { get; set; }
}
