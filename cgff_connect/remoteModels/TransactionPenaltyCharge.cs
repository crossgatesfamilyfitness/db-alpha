using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TransactionPenaltyCharge
{
    public int Id { get; set; }

    public int ChargeId { get; set; }

    public int TransactionId { get; set; }

    public string FeeAdded { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
