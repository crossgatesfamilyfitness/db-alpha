using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionCyclePrice
{
    public int Id { get; set; }

    public int? UserGroupSubscriptionBillingOptionId { get; set; }

    public int? UserGroupSubscriptionPriceId { get; set; }

    public int? GroupEntityCyclePriceId { get; set; }

    public int? UserGroupSubscriptionPriceDetailId { get; set; }

    public int? GroupId { get; set; }

    public short Cycle { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal? BaseFee { get; set; }

    public bool? KeepActive { get; set; }

    public bool? BillMonth { get; set; }

    public bool DueNow { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
