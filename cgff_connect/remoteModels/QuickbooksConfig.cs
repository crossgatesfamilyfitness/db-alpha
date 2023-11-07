using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksConfig
{
    public uint QuickbooksConfigId { get; set; }

    public string QbUsername { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string Cfgkey { get; set; } = null!;

    public string Cfgval { get; set; } = null!;

    public string Cfgtype { get; set; } = null!;

    public string Cfgopts { get; set; } = null!;

    public DateTime WriteDatetime { get; set; }

    public DateTime ModDatetime { get; set; }
}
