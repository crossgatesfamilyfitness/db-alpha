using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionMaintenanceFee
{
    public int Id { get; set; }

    public int? UserGroupSubscriptionBillingOptionId { get; set; }

    public int? GroupEntityMaintenanceFeeId { get; set; }

    public int? GroupId { get; set; }

    public string? Type { get; set; }

    public short? CycleDuration { get; set; }

    public string? CycleType { get; set; }

    public short? DelayInterval { get; set; }

    public string? DelayIntervalType { get; set; }

    public short? BillDay { get; set; }

    public short? BillMonth { get; set; }

    public string? StatementDescription { get; set; }

    public decimal? Fee { get; set; }

    public int? AccountingGroupId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
