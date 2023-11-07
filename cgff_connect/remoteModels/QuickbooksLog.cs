using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksLog
{
    public uint QuickbooksLogId { get; set; }

    public uint? QuickbooksTicketId { get; set; }

    public uint Batch { get; set; }

    public string Msg { get; set; } = null!;

    public DateTime LogDatetime { get; set; }
}
