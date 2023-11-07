using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class Attendance
{
    public ulong Id { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public uint ModifiedBy { get; set; }

    public string Track { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public string UpdatedColumns { get; set; } = null!;

    public string OldValues { get; set; } = null!;

    public string NewValues { get; set; } = null!;

    public uint AttendanceId { get; set; }

    public ulong ScheduleId { get; set; }

    public uint ResourceId { get; set; }

    public uint UserId { get; set; }

    public string? AType { get; set; }

    public string Attendance1 { get; set; } = null!;

    public string? LogTransactionId { get; set; }
}
