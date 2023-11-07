using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AddonResourceNote
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public string Note { get; set; } = null!;

    public bool Active { get; set; }

    public virtual AddonResource Resource { get; set; } = null!;
}
