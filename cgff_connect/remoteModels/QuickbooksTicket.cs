using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksTicket
{
    public uint QuickbooksTicketId { get; set; }

    public string QbUsername { get; set; } = null!;

    public string Ticket { get; set; } = null!;

    public uint? Processed { get; set; }

    public string? LasterrorNum { get; set; }

    public string? LasterrorMsg { get; set; }

    public string Ipaddr { get; set; } = null!;

    public DateTime WriteDatetime { get; set; }

    public DateTime TouchDatetime { get; set; }
}
