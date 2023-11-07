using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class NotificationList
{
    public int Id { get; set; }

    public bool Type { get; set; }

    public int UserId { get; set; }

    public int EventId { get; set; }

    public int ScheduleId { get; set; }

    public DateTime Time { get; set; }

    public bool SenderType { get; set; }

    public bool? Status { get; set; }

    public string Params { get; set; } = null!;
}
