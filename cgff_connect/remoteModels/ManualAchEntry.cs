using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ManualAchEntry
{
    public int Id { get; set; }

    public int BatchId { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public float Amount { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string RoutingNumber { get; set; } = null!;

    public string Status { get; set; } = null!;

    public bool? BankAccountType { get; set; }
}
