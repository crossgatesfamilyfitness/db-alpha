using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PayrollQuestion
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public uint PayrollStaff { get; set; }

    public DateOnly Date { get; set; }

    public string Text { get; set; } = null!;

    public bool? Enabled { get; set; }

    public bool? IsNew { get; set; }
}
