using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Payroll
{
    public long Id { get; set; }

    public int StaffId { get; set; }

    public DateOnly Date { get; set; }

    public DateTime DateTime { get; set; }

    public long EventId { get; set; }

    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public float Amount { get; set; }

    public bool Blocked { get; set; }

    public DateOnly BlockedDate { get; set; }

    public DateTime BlockedTime { get; set; }

    public int AddedBy { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int EntityId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
