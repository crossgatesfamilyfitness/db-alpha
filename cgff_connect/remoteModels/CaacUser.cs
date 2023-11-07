using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CaacUser
{
    public int UserId { get; set; }

    public int DoorId { get; set; }

    public string AccountNum { get; set; } = null!;

    public int FacilityCode { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Errors { get; set; } = null!;

    public DateOnly LastUpdate { get; set; }

    public string DaySettings { get; set; } = null!;

    public sbyte Export { get; set; }
}
