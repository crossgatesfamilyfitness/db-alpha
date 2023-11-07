using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionSale
{
    public int Id { get; set; }

    public int? UserGroupSubscriptionBillingOptionId { get; set; }

    public int? GroupId { get; set; }

    public int? SalesId { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
