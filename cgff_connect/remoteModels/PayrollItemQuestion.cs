using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PayrollItemQuestion
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int PayrollStaff { get; set; }

    public DateTime Date { get; set; }

    public long PayrollRowId { get; set; }

    public string Type { get; set; } = null!;

    public string Question { get; set; } = null!;
}
