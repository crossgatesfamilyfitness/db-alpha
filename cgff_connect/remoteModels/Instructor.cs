using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Instructor
{
    public int Id { get; set; }

    public int InstructorId { get; set; }

    public int Number { get; set; }

    public ulong ScheduleId { get; set; }

    public float CustomPrice { get; set; }

    public string? CustomPriceType { get; set; }

    public float StaffCourtFee { get; set; }

    public float CalcStaffCourtFee { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public bool Attended { get; set; }

    public bool ChargedNotAttended { get; set; }

    public short ComplimentaryRoundCategoryId { get; set; }

    /// <summary>
    /// Is used for Scheduler Events
    /// </summary>
    public string ParticipantStatus { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
