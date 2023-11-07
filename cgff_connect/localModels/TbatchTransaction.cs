using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class TbatchTransaction
{
    public ulong Id { get; set; }

    public ulong TbatchId { get; set; }

    public ulong TransactionId { get; set; }
}
