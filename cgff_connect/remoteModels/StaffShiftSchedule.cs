using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffShiftSchedule
{
    public long Id { get; set; }

    /// <summary>
    /// Staff
    /// </summary>
    public long UserId { get; set; }

    public int? ComponentId { get; set; }

    public int? EntityId { get; set; }

    public string RecurrenceType { get; set; } = null!;

    /// <summary>
    /// Original start date
    /// </summary>
    public DateOnly DateFrom { get; set; }

    /// <summary>
    /// Original end date
    /// </summary>
    public DateOnly DateTo { get; set; }

    /// <summary>
    /// Json array from 1 (monday) to 7 (sunday)
    /// </summary>
    public string WeekDayNumbers { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public int ModifiedByIntranet { get; set; }

    public string? LastTrack { get; set; }

    public string? Params { get; set; }

    public virtual ICollection<StaffShift> StaffShifts { get; } = new List<StaffShift>();
}
