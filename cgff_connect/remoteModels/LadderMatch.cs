using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LadderMatch
{
    public int Id { get; set; }

    public uint PlayerId { get; set; }

    public uint? ChallengerId { get; set; }

    public sbyte? ChallengeAccepted { get; set; }

    public sbyte? Won { get; set; }

    public DateOnly? Date { get; set; }

    public string? Score { get; set; }
}
