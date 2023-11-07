using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserContractToUserGroupSubscriptionPricingTable
{
    public int Id { get; set; }

    public int? UserContractToUserGroupSubscriptionId { get; set; }

    public int? UserContractId { get; set; }

    public int? UserGroupSubscriptionId { get; set; }

    public DateOnly Date { get; set; }

    public decimal Amount { get; set; }
}
