using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CheckinError
{
    public int CheckinId { get; set; }

    public int ErrorType { get; set; }
}
