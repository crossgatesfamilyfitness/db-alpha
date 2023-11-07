using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BamboraBatchTransaction
{
    public int Id { get; set; }

    public int? BatchId { get; set; }

    public int Amount { get; set; }

    public long TransactionId { get; set; }

    public string AccountToken { get; set; } = null!;

    public string SubmitStatus { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public int MerchantId { get; set; }
}
