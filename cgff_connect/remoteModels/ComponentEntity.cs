using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ComponentEntity
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public int? ComponentId { get; set; }

    public virtual Component? Component { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }
}
