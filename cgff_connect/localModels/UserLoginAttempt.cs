using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class UserLoginAttempt
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public string? Ip { get; set; }

    public DateTime Created { get; set; }

    public bool Type { get; set; }

    public bool? LockCounted { get; set; }
}
