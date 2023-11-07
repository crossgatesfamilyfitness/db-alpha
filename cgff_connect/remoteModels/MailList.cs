using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailList
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Recipients { get; set; }

    public DateTime? Modified { get; set; }

    public bool EventList { get; set; }

    public bool Temp { get; set; }
}
