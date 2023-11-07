using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaServiceNote
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public int UserId { get; set; }

    public string? Note { get; set; }

    public string? StaffNote { get; set; }
}
