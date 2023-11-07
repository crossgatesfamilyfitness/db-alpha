using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaStaffServicePrice
{
    public uint Id { get; set; }

    public uint ResourceId { get; set; }

    public uint ServiceId { get; set; }

    public ushort Period { get; set; }

    public decimal Price { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
