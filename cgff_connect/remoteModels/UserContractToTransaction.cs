using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserContractToTransaction
{
    public int Id { get; set; }

    public ulong? TransactionId { get; set; }

    public int? UserContractId { get; set; }
}
