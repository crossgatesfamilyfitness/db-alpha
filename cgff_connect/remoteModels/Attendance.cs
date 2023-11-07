using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Attendance
{
    public int Id { get; set; }

    public ulong ScheduleId { get; set; }

    public int ResourceId { get; set; }

    public int UserId { get; set; }

    public string Type { get; set; } = null!;

    public DateOnly MakeUpDate { get; set; }

    public string Attendance1 { get; set; } = null!;

    public TimeOnly AttendFrom { get; set; }

    public TimeOnly AttendTo { get; set; }

    public string Params { get; set; } = null!;

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public sbyte IsOnline { get; set; }

    public sbyte FromWaitlist { get; set; }

    public bool ChargedNotAttended { get; set; }

    public byte? SortOrder { get; set; }

    public DateTime? ConfirmationExpiryDate { get; set; }

    public sbyte IsWaitlistMail { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
