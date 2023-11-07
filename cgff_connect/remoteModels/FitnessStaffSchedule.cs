using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class FitnessStaffSchedule
{
    public uint Id { get; set; }

    public uint StaffId { get; set; }

    public DateOnly Date { get; set; }

    public int GroupId { get; set; }

    public TimeOnly TimeFrom { get; set; }

    public TimeOnly TimeTo { get; set; }
}
