using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AgilysysPosItem
{
    public int Id { get; set; }

    public string ItemName { get; set; } = null!;

    public int InterfaceId { get; set; }
}
