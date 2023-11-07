using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Content
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Introtext { get; set; }

    public string? Fulltext { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Updated { get; set; }

    public int CategoryId { get; set; }

    public int? Frontpage { get; set; }

    public uint? AuthorId { get; set; }

    public sbyte Published { get; set; }

    public string? PreviewImage { get; set; }
}
