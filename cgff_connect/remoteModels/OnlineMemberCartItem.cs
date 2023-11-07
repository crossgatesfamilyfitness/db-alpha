using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineMemberCartItem
{
    public uint Id { get; set; }

    public uint OnlineCartId { get; set; }

    public uint? ParentId { get; set; }

    public string Role { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
