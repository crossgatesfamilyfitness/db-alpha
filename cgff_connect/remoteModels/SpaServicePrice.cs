using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaServicePrice
{
    public uint Id { get; set; }

    public uint ServiceId { get; set; }

    public ushort Period { get; set; }

    public decimal Price { get; set; }
}
