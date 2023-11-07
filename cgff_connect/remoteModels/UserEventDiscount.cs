using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserEventDiscount
{
    public int Id { get; set; }

    public sbyte RegType { get; set; }

    public int UserId { get; set; }

    public int AuthId { get; set; }

    public ulong EventIn { get; set; }

    public ulong EventFor { get; set; }

    public int UserFor { get; set; }
}
