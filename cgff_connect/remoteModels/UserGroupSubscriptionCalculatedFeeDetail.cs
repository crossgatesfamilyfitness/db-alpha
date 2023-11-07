using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionCalculatedFeeDetail
{
    public int Id { get; set; }

    public int? UserGroupSubscriptionCalculatedFeeId { get; set; }

    public int? UserGroupSubscriptionId { get; set; }

    public decimal? DefaultAmount { get; set; }

    public decimal? CycleDefaultAmount { get; set; }

    public decimal? DiscountedAmount { get; set; }

    public decimal? CorporateDiscountedAmount { get; set; }

    public decimal? ProrateAmount { get; set; }

    public decimal? CycleDiscountedAmount { get; set; }

    public decimal? HoldAmount { get; set; }

    public decimal BillAmount { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
