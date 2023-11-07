using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaAddonPrice
{
    public uint Id { get; set; }

    public uint AddonId { get; set; }

    public ushort Period { get; set; }

    public decimal Price { get; set; }
}
