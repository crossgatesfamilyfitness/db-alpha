using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceFee
{
    public ulong Id { get; set; }

    public int? ServiceId { get; set; }

    public int? EntityId { get; set; }

    public int? StaffLevelId { get; set; }

    public int? StaffId { get; set; }

    public string FeeType { get; set; } = null!;

    public int NumParticipants { get; set; }

    public decimal? MemberFee { get; set; }

    public decimal? GuestFee { get; set; }

    public decimal? EmployeeFee { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual Service? Service { get; set; }

    public virtual ICollection<ServicePricingGroupServiceFee> ServicePricingGroupServiceFees { get; } = new List<ServicePricingGroupServiceFee>();

    public virtual StaffLevel? StaffLevel { get; set; }
}
