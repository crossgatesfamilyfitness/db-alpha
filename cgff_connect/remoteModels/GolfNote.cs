using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GolfNote
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int ResourceId { get; set; }

    public string? Text { get; set; }

    public DateTime VersionDate { get; set; }

    public int UserId { get; set; }
}
