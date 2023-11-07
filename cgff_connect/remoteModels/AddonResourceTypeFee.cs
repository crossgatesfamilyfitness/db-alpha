using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AddonResourceTypeFee
{
    public int Id { get; set; }

    public int AddonId { get; set; }

    public int BillingAddonId { get; set; }

    public int ResourceTypeId { get; set; }

    public decimal Fee { get; set; }

    public int AccountingGroupId { get; set; }

    public decimal ActivationFee { get; set; }

    public int ActivationAccountingGroupId { get; set; }

    public int LiabilityAccountingGroupId { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
