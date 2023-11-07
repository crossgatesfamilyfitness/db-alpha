using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserQueueGroupAdditionalCharge
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? GroupIdOld { get; set; }

    public int? UserId { get; set; }

    public int? AdditionalChargeId { get; set; }

    public decimal Fee { get; set; }
}
