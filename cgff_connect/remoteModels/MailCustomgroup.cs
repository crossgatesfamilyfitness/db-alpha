using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailCustomgroup
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string GroupParams { get; set; } = null!;
}
