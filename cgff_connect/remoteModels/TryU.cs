using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TryU
{
    public uint Id { get; set; }

    public uint LocationId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;
}
