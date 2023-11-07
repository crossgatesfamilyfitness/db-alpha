using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PncAchBatch
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public sbyte Status { get; set; }
}
