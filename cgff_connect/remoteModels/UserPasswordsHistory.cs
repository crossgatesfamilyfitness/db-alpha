using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPasswordsHistory
{
    public uint Id { get; set; }

    public int UserId { get; set; }

    public string Password { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
