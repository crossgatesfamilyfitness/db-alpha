using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Faq
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Introtext { get; set; }

    public string? Fulltext { get; set; }

    public DateTime? Created { get; set; }
}
