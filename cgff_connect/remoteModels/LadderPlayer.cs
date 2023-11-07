using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LadderPlayer
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public short Section { get; set; }

    public short Level { get; set; }

    public short Rank { get; set; }

    public sbyte? Active { get; set; }

    public DateOnly? StartDate { get; set; }
}
