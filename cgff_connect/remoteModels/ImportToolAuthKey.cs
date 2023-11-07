using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportToolAuthKey
{
    public int Id { get; set; }

    public string MicroserviceInstance { get; set; } = null!;

    public string AuthKey { get; set; } = null!;

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public DateTime ModifiedDate { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
