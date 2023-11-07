using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TournamentDraw
{
    public int Id { get; set; }

    public int TournamentId { get; set; }

    public string? Name { get; set; }
}
