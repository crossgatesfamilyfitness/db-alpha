using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserLoginLock
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LockedUntil { get; set; }

    public string? Ip { get; set; }
}
