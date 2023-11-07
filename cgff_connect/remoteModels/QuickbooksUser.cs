using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksUser
{
    public string QbUsername { get; set; } = null!;

    public string QbPassword { get; set; } = null!;

    public string? QbCompanyFile { get; set; }

    public uint? QbwcWaitBeforeNextUpdate { get; set; }

    public uint? QbwcMinRunEveryNSeconds { get; set; }

    public string Status { get; set; } = null!;

    public DateTime WriteDatetime { get; set; }

    public DateTime TouchDatetime { get; set; }
}
