using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppleWalletRegistration
{
    public uint Id { get; set; }

    public string State { get; set; } = null!;

    public uint AuthId { get; set; }

    public string DeviceId { get; set; } = null!;

    public string PushToken { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public string PassTypeId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual AppleWalletAuth Auth { get; set; } = null!;
}
