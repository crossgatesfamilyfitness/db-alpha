using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Checkin
{
    public long Id { get; set; }

    public uint? UserId { get; set; }

    public DateTime In { get; set; }

    public DateTime? Out { get; set; }

    public int? DepartmentId { get; set; }

    public DateOnly Date { get; set; }

    public bool Blocked { get; set; }

    public DateOnly BlockedDate { get; set; }

    public DateTime BlockedTime { get; set; }

    public int? EntityId { get; set; }

    public int CaacDoorId { get; set; }

    public int LocationId { get; set; }

    public DateTime UtcTimestamp { get; set; }

    /// <summary>
    /// 0 or 1. Based on checkin errors
    /// </summary>
    public bool Denied { get; set; }
}
