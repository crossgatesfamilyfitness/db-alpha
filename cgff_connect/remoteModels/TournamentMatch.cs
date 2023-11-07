using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TournamentMatch
{
    public int Id { get; set; }

    public int? DrawId { get; set; }

    public uint? FirstPlayer { get; set; }

    public uint? SecondPlayer { get; set; }

    public uint? Winner { get; set; }

    public string? Score { get; set; }

    public int? Parent { get; set; }

    public short Round { get; set; }
}
