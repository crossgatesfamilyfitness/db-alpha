using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RepairStaffField
{
    public uint UserId { get; set; }

    public string PayrollRate { get; set; } = null!;
}
