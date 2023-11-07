using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ClubGatewayInformation
{
    public uint Id { get; set; }

    public int MerchantRetailerId { get; set; }

    public string Gateway { get; set; } = null!;

    public string? GatewayHost { get; set; }

    public string? GatewayInfo { get; set; }

    public DateTime CreatedDate { get; set; }
}
