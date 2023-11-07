using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Component
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string CreationDate { get; set; } = null!;

    public DateOnly InstallationDate { get; set; }

    public string Version { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Uninstall { get; set; } = null!;

    public string Permanent { get; set; } = null!;

    public string? Settings { get; set; }

    public string Modules { get; set; } = null!;

    public string? CampSettings { get; set; }

    public string Payroll { get; set; } = null!;

    public string BillingRates { get; set; } = null!;

    public bool SchedulingTool { get; set; }

    public virtual ICollection<ComponentEntity> ComponentEntities { get; } = new List<ComponentEntity>();

    public virtual ICollection<CourtLocationComponent> CourtLocationComponents { get; } = new List<CourtLocationComponent>();

    public virtual ICollection<LessonTypeOnlineBookingSetting> LessonTypeOnlineBookingSettings { get; } = new List<LessonTypeOnlineBookingSetting>();

    public virtual ICollection<LessonTypeOnlineStaffAssignment> LessonTypeOnlineStaffAssignments { get; } = new List<LessonTypeOnlineStaffAssignment>();

    public virtual ICollection<LessonTypeStaffAssignment> LessonTypeStaffAssignments { get; } = new List<LessonTypeStaffAssignment>();

    public virtual ICollection<OnlineBookingSetting> OnlineBookingSettings { get; } = new List<OnlineBookingSetting>();

    public virtual ICollection<ServicePricingGroup> ServicePricingGroups { get; } = new List<ServicePricingGroup>();

    public virtual ICollection<ServiceType> ServiceTypes { get; } = new List<ServiceType>();

    public virtual ICollection<StaffLevelUser> StaffLevelUsers { get; } = new List<StaffLevelUser>();

    public virtual ICollection<StaffLevel> StaffLevels { get; } = new List<StaffLevel>();

    public virtual ICollection<StaffSchedule> StaffSchedules { get; } = new List<StaffSchedule>();
}
