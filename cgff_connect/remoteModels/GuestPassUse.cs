using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GuestPassUse
{
    public ulong Id { get; set; }

    public uint UserId { get; set; }

    public uint GuestId { get; set; }

    public uint PackageId { get; set; }

    public DateTime UsedDate { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
