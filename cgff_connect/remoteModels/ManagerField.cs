using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ManagerField
{
    /// <summary>
    /// User ID
    /// </summary>
    public uint UserId { get; set; }

    /// <summary>
    /// PIN
    /// </summary>
    public string? Pin { get; set; }
}
