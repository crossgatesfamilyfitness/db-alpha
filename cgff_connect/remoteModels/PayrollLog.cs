using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PayrollLog
{
    public long Id { get; set; }

    /// <summary>
    /// date to display on
    /// </summary>
    public DateOnly Date { get; set; }

    public DateTime DateTime { get; set; }

    /// <summary>
    /// initial / update
    /// </summary>
    public sbyte Type { get; set; }

    /// <summary>
    /// lesson charge / club fee / commission
    /// </summary>
    public int RowType { get; set; }

    /// <summary>
    /// regular/ history / unsettled 
    /// </summary>
    public sbyte PayrollType { get; set; }

    public int StaffId { get; set; }

    /// <summary>
    /// player id if needed
    /// </summary>
    public int UserId { get; set; }

    public long EventId { get; set; }

    public int EventType { get; set; }

    public long ScheduleId { get; set; }

    public int ResourceId { get; set; }

    public string? PlayerIds { get; set; }

    public DateOnly? ScheduleDate { get; set; }

    public float Duration { get; set; }

    public decimal Amount { get; set; }

    /// <summary>
    /// reason behind this change
    /// </summary>
    public int LogType { get; set; }

    /// <summary>
    /// charge/payment/refund ids
    /// </summary>
    public string? Subject { get; set; }

    public string? Params { get; set; }

    public sbyte AttendanceIncomplete { get; set; }

    public bool Blocked { get; set; }

    public DateOnly BlockedDate { get; set; }

    public DateTime BlockedTime { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    /// <summary>
    /// no need to store all track, keep the url of last change
    /// </summary>
    public string? LastUrl { get; set; }

    public string? LastTrack { get; set; }

    public int? LocationId { get; set; }

    public int? ComponentId { get; set; }

    public int? ServiceId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
