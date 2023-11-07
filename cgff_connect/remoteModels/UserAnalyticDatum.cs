using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserAnalyticDatum
{
    public uint Id { get; set; }

    public uint? UserId { get; set; }

    public DateOnly? LastCheckinDate { get; set; }

    public DateTime? LastCheckinDatetime { get; set; }
}
