using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Invitation
{
    public uint Id { get; set; }

    public uint ScheduleId { get; set; }

    public uint UserId { get; set; }

    public string? Hash { get; set; }

    public uint MailId { get; set; }
}
