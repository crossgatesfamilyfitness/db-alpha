using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class DefaultStaffRate
{
    public int Id { get; set; }

    public int ComponentId { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public int ParentRule { get; set; }

    public string? Season { get; set; }

    public string? Level { get; set; }

    public string? LessonType { get; set; }

    public string? Membership { get; set; }

    public string? Rates { get; set; }

    public int RatesPlayersCount { get; set; }

    public string? PrimeRates { get; set; }

    public DateTime DateCreated { get; set; }

    public bool Default { get; set; }

    public sbyte Status { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
