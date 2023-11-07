using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class FrontDeskClerkField
{
    /// <summary>
    /// User ID
    /// </summary>
    public uint UserId { get; set; }

    /// <summary>
    /// Can do refunds
    /// </summary>
    public byte CanRefund { get; set; }

    public string AllowedPos { get; set; } = null!;

    public string PosPin { get; set; } = null!;
}
