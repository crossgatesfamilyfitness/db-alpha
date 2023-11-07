using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RewardRule
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public sbyte FrequencyType { get; set; }

    public int Frequency { get; set; }

    public string Memberships { get; set; } = null!;

    public string Receiver { get; set; } = null!;

    public float Points { get; set; }

    public DateOnly CreatedDate { get; set; }

    public DateOnly LastIssueDate { get; set; }

    public DateOnly? NextIssueDate { get; set; }

    public sbyte Status { get; set; }
}
