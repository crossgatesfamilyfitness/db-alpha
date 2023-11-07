using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CaMenuItem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? HtmlClass { get; set; }

    public string? HtmlId { get; set; }

    public int Order { get; set; }

    public int MenuId { get; set; }

    public int ParentId { get; set; }

    public string SystemName { get; set; } = null!;

    public virtual CaMenu Menu { get; set; } = null!;
}
