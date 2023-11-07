using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserMailgroup
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    public int GroupId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;
}
