using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class DeclineFee
{
    public int Id { get; set; }

    public int ChargeId { get; set; }

    public int CountOfAttempts { get; set; }

    public DateOnly LastAttemptDate { get; set; }
}
