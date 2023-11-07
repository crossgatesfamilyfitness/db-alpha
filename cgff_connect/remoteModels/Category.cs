using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Category
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? ParentId { get; set; }

    public string? Description { get; set; }
}
