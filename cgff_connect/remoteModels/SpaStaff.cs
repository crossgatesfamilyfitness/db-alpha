using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SpaStaff
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public int ServiceId { get; set; }

    public decimal Price { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
