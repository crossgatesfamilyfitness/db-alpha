using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Calendar
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int DefaultComponentId { get; set; }

    public string Status { get; set; } = null!;

    public string System { get; set; } = null!;
}
