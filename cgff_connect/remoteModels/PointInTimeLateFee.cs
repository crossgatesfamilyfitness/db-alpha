using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PointInTimeLateFee
{
    public int AccountHolderId { get; set; }

    public DateTime DateCreated { get; set; }

    public bool AlreadyChargedFor { get; set; }
}
