using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LessonType
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool Status { get; set; }

    public int ComponentId { get; set; }

    public string? Names { get; set; }

    public string? CourtDescriptionShort { get; set; }

    public string? CourtDescription { get; set; }

    public string? EntityId { get; set; }

    public string? LimitByRevenue { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public string? PackageRequired { get; set; }

    public virtual ICollection<LessonTypeOnlineBookingSetting> LessonTypeOnlineBookingSettings { get; } = new List<LessonTypeOnlineBookingSetting>();

    public virtual ICollection<LessonTypeOnlineStaffAssignment> LessonTypeOnlineStaffAssignments { get; } = new List<LessonTypeOnlineStaffAssignment>();

    public virtual ICollection<LessonTypeStaffAssignment> LessonTypeStaffAssignments { get; } = new List<LessonTypeStaffAssignment>();
}
