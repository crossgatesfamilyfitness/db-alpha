using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PayrollApproved
{
    public int StaffId { get; set; }

    public DateOnly DateFrom { get; set; }

    public DateOnly DateTo { get; set; }
}
