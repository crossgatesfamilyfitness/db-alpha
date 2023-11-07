using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserAuthhashToGuestHash
{
    public uint Id { get; set; }

    public int? AuthhashId { get; set; }

    public int? GuestHashId { get; set; }
}
