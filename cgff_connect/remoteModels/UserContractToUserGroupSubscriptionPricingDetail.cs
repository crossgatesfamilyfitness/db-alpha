using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserContractToUserGroupSubscriptionPricingDetail
{
    public int Id { get; set; }

    public int? UserContractToUserGroupSubscriptionId { get; set; }

    public int? UserContractId { get; set; }

    public int? UserGroupSubscriptionId { get; set; }

    public string Title { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Type { get; set; }
}
