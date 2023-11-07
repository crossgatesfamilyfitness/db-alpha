using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TransactionInfrastructureFee
{
    public int Id { get; set; }

    public int AccountingGroupId { get; set; }

    public float TotalFeeApplied { get; set; }

    public decimal PaymentTransactionAmount { get; set; }

    public int TransactionId { get; set; }

    public bool Status { get; set; }
}
