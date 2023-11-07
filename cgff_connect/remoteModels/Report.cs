using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Report
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? Template { get; set; }

    public sbyte AccessLevel { get; set; }

    public string Fields { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public sbyte RecordType { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
