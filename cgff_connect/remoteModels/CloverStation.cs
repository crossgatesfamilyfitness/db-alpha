using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CloverStation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string MerchantId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public int AccountingGroupId { get; set; }

    public string Prefix { get; set; } = null!;
}
