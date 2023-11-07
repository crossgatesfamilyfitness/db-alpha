using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class CaMenu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ParentId { get; set; }

    public string SystemName { get; set; } = null!;

    public virtual ICollection<CaMenuItem> CaMenuItems { get; } = new List<CaMenuItem>();
}
