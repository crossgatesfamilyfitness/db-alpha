using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CronScript
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Function { get; set; } = null!;

    public int MailTemplateId { get; set; }

    public string CronStatus { get; set; } = null!;

    public string AutoStatus { get; set; } = null!;

    public string ManualStatus { get; set; } = null!;

    public string ScheduleType { get; set; } = null!;

    public int Frequency { get; set; }

    public int DayAt { get; set; }

    public int MonthAt { get; set; }

    public DateTime? LaunchAt { get; set; }

    public int LastCronDate { get; set; }

    public int? LastCronFinishDate { get; set; }

    public string Params { get; set; } = null!;

    public int Ordernum { get; set; }

    /// <summary>
    /// 0 - before, 1 - after
    /// </summary>
    public bool RunAfterScheduled { get; set; }

    public bool Status { get; set; }

    public TimeOnly? BlockedTimeFrom { get; set; }

    public TimeOnly? BlockedTimeTo { get; set; }

    public string ProcessorType { get; set; } = null!;

    public string? GroupName { get; set; }

    public TimeOnly TimeToRun { get; set; }

    public DateTime? QueuedTime { get; set; }

    public TimeOnly? ExecutionTimeout { get; set; }

    public bool IsCritical { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
