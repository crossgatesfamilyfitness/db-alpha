using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineReservationMatrix
{
    public int Id { get; set; }

    public int ComponentId { get; set; }

    public int GroupId { get; set; }

    public int DaysAmount { get; set; }

    public int ArrayId { get; set; }
}
