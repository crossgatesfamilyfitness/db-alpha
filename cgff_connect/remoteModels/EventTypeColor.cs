using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventTypeColor
{
    public int EventTypeId { get; set; }

    public string? BackgroundColor { get; set; }

    public string? SecondaryColor { get; set; }

    public string? TextColor { get; set; }
}
