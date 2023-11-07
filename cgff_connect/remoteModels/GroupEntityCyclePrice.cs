using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupEntityCyclePrice
{
    public int Id { get; set; }

    public int? GroupEntityBillingId { get; set; }

    public int? GroupId { get; set; }

    public int? EntityId { get; set; }

    public int? GroupEntityDefaultPriceId { get; set; }

    public short Cycle { get; set; }

    public decimal? BaseFee { get; set; }

    public bool? KeepActive { get; set; }

    public bool? BillMonth { get; set; }

    public bool DueNow { get; set; }
}
