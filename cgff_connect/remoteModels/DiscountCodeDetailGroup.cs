using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class DiscountCodeDetailGroup
{
    public long Id { get; set; }

    public long? DiscountCodeDetailId { get; set; }

    public int? GroupId { get; set; }

    public virtual DiscountCodeDetail? DiscountCodeDetail { get; set; }
}
