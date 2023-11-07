using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ResourceWaitlist
{
    public long Id { get; set; }

    public int ComponentId { get; set; }

    public int LocationId { get; set; }

    public int UserId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public short Duration { get; set; }

    public int? CourtTypeId { get; set; }

    public int? CourtId { get; set; }

    public bool IsBallMachine { get; set; }

    /// <summary>
    /// Added / Notified / Unsubscribed / Expired
    /// </summary>
    public sbyte Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }
}
