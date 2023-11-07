using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GuestFeesVisit
{
    public ulong Id { get; set; }

    public int UserId { get; set; }

    public DateOnly Date { get; set; }
}
