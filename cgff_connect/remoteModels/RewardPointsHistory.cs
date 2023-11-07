using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RewardPointsHistory
{
    public ulong Id { get; set; }

    public int UserId { get; set; }

    public decimal Points { get; set; }

    public decimal PointsLeft { get; set; }

    public DateTime Datetime { get; set; }

    public DateOnly Date { get; set; }

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int IssuedBy { get; set; }

    public bool Removed { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public int RuleId { get; set; }

    public DateOnly ExpiredDate { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
