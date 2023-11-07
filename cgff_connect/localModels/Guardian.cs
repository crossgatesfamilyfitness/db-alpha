using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Guardian
{
    public uint Id { get; set; }

    public uint GuardianId { get; set; }

    public uint ChildId { get; set; }
}
