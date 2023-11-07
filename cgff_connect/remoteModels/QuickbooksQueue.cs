using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksQueue
{
    public uint QuickbooksQueueId { get; set; }

    public uint? QuickbooksTicketId { get; set; }

    public string QbUsername { get; set; } = null!;

    public string QbAction { get; set; } = null!;

    public string Ident { get; set; } = null!;

    public string? Extra { get; set; }

    public string? Qbxml { get; set; }

    public uint? Priority { get; set; }

    public string QbStatus { get; set; } = null!;

    public string? Msg { get; set; }

    public DateTime EnqueueDatetime { get; set; }

    public DateTime? DequeueDatetime { get; set; }
}
