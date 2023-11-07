using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionPrice
{
    public int Id { get; set; }

    public int? UserGroupSubscriptionBillingOptionId { get; set; }

    public int? GroupEntityPriceId { get; set; }

    public int? GroupId { get; set; }

    public string FamilyRole { get; set; } = null!;

    public short Order { get; set; }

    public decimal? BaseFee { get; set; }

    public decimal? EnrollmentFee { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
