using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CourtSale
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public int RoomId { get; set; }

    public ulong ScheduleId { get; set; }

    public uint AddedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }

    public string Status { get; set; } = null!;

    public uint Owner { get; set; }

    public DateOnly ReservationDate { get; set; }

    public string TimeFrom { get; set; } = null!;

    public string TimeTo { get; set; } = null!;
}
