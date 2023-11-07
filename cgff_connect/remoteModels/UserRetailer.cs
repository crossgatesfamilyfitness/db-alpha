using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserRetailer
{
    public uint Id { get; set; }

    public int UserId { get; set; }

    public int MerchantRetailerId { get; set; }

    public string CustomerToken { get; set; } = null!;
}
