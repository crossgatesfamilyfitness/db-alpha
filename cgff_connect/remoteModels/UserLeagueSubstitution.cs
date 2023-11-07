using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserLeagueSubstitution
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int EventId { get; set; }

    public string PlayerNumber { get; set; } = null!;

    public string Comment { get; set; } = null!;
}
