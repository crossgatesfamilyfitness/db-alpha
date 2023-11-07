using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserBankAccountRetailer
{
    public uint Id { get; set; }

    public int UserBankAccountId { get; set; }

    public int MerchantRetailerId { get; set; }

    public string AccountToken { get; set; } = null!;
}
