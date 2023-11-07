using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionAdditionalCharge
{
    public int Id { get; set; }

    public int? UserGroupSubscriptionBillingOptionId { get; set; }

    public int? GroupId { get; set; }

    public int? AccountingGroupId { get; set; }

    public decimal Amount { get; set; }

    public string StatementDescription { get; set; } = null!;
}
