using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppleWalletAuth
{
    public uint Id { get; set; }

    public int UserId { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string AuthToken { get; set; } = null!;

    public string PassTypeId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime LastHitAt { get; set; }

    public uint HitsCount { get; set; }

    public virtual ICollection<AppleWalletRegistration> AppleWalletRegistrations { get; } = new List<AppleWalletRegistration>();

    public virtual User User { get; set; } = null!;
}
