using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CardconnectBatchTransaction
{
    public int Id { get; set; }

    public int? BatchId { get; set; }

    public int Amount { get; set; }

    public string TransactionId { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public string? Name { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string Bankaba { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string SubmitStatus { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public int MerchantId { get; set; }
}
