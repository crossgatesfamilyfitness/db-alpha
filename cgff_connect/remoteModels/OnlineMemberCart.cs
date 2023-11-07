using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineMemberCart
{
    public uint Id { get; set; }

    public uint? UserId { get; set; }

    public int? GuestHashId { get; set; }

    public DateTime CreatedAt { get; set; }
}
