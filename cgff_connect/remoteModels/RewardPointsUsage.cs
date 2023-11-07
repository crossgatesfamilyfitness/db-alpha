using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RewardPointsUsage
{
    public ulong Id { get; set; }

    public ulong HistoryId { get; set; }

    public ulong PtransactionId { get; set; }

    public int UserId { get; set; }

    public decimal Points { get; set; }

    public decimal Ratio { get; set; }

    public DateTime Datetime { get; set; }

    public DateOnly Date { get; set; }

    public int ProcessedBy { get; set; }
}
