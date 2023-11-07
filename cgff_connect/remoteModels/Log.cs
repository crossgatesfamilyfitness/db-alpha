using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Log
{
    public long Id { get; set; }

    public string? Priority { get; set; }

    public string? Message { get; set; }

    public DateTime Created { get; set; }

    public string? Username { get; set; }
}
