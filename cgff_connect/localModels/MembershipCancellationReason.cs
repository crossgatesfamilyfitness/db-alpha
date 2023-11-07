using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class MembershipCancellationReason
{
    public uint Id { get; set; }

    public string Reason { get; set; } = null!;
}
