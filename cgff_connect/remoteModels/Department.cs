using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Department
{
    public int Id { get; set; }

    public int ComponentId { get; set; }

    public string Title { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly CreationDate { get; set; }

    public string? Description { get; set; }

    public sbyte? Status { get; set; }

    public string StaffRateTable { get; set; } = null!;
}
