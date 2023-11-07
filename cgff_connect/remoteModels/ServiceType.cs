using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceType
{
    public int Id { get; set; }

    public int? ComponentId { get; set; }

    public int? ParentId { get; set; }

    public int? EventTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string ColorCode { get; set; } = null!;

    public bool CancellationFee { get; set; }

    public int CancellationFeeWindow { get; set; }

    public bool NoShowFee { get; set; }

    public bool? Active { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public bool AnyLocation { get; set; }

    public bool AnyDuration { get; set; }

    public bool AnyStaff { get; set; }

    public bool? HasFees { get; set; }

    public bool? HasCommissions { get; set; }

    public bool AnyComponent { get; set; }

    public bool IsSystem { get; set; }

    public virtual Component? Component { get; set; }

    public virtual EventType? EventType { get; set; }

    public virtual ICollection<ServiceType> InverseParent { get; } = new List<ServiceType>();

    public virtual ServiceType? Parent { get; set; }

    public virtual ICollection<ServiceAccountingGroup> ServiceAccountingGroups { get; } = new List<ServiceAccountingGroup>();

    public virtual ICollection<ServiceAlternateFee> ServiceAlternateFees { get; } = new List<ServiceAlternateFee>();

    public virtual ICollection<ServiceFeeRule> ServiceFeeRules { get; } = new List<ServiceFeeRule>();

    public virtual ICollection<ServiceLocation> ServiceLocations { get; } = new List<ServiceLocation>();

    public virtual ICollection<ServiceOnlineBookingRule> ServiceOnlineBookingRules { get; } = new List<ServiceOnlineBookingRule>();

    public virtual ICollection<ServiceParticipationRule> ServiceParticipationRules { get; } = new List<ServiceParticipationRule>();

    public virtual ICollection<ServicePricingGroupServiceType> ServicePricingGroupServiceTypes { get; } = new List<ServicePricingGroupServiceType>();

    public virtual ICollection<ServiceSchedule> ServiceSchedules { get; } = new List<ServiceSchedule>();

    public virtual ICollection<ServiceStaff> ServiceStaffs { get; } = new List<ServiceStaff>();

    public virtual ICollection<Service> Services { get; } = new List<Service>();

    public virtual ICollection<StaffScheduleService> StaffScheduleServices { get; } = new List<StaffScheduleService>();
}
