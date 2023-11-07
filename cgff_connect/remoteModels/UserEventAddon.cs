using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserEventAddon
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int EventId { get; set; }

    public sbyte AddonId { get; set; }

    public DateOnly Date { get; set; }

    public sbyte Status { get; set; }

    public bool IsMakeup { get; set; }
}
