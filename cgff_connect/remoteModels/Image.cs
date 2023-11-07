using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Image
{
    public int Id { get; set; }

    public int RowId { get; set; }

    public string ModelName { get; set; } = null!;

    public int Active { get; set; }

    public string Src { get; set; } = null!;

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public string ScaleType { get; set; } = null!;

    public int OriginalId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
