using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EndOfDay
{
    public ulong Id { get; set; }

    public DateOnly Date { get; set; }

    public DateOnly DateClosed { get; set; }

    public float Cash { get; set; }

    public float Check { get; set; }

    public int PosId { get; set; }

    public TimeOnly TimeOpened { get; set; }

    public TimeOnly TimeClosed { get; set; }

    public uint OpenedBy { get; set; }

    public uint ClosedBy { get; set; }

    public sbyte Status { get; set; }
}
