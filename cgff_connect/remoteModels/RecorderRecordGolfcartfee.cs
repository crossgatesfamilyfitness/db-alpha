using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RecorderRecordGolfcartfee
{
    public long Id { get; set; }

    /// <summary>
    /// touched shop items Ids
    /// </summary>
    public string Data { get; set; } = null!;
}
