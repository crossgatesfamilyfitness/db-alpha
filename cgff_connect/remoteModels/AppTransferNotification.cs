using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppTransferNotification
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime Time { get; set; }
}
