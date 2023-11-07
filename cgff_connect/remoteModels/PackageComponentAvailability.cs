using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PackageComponentAvailability
{
    public uint Id { get; set; }

    public int ComponentId { get; set; }

    public bool IsEnabled { get; set; }
}
