using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksExportMapping
{
    public int Id { get; set; }

    public string? AccGroupCode { get; set; }

    public string? QbAccountName { get; set; }

    public string? QbMemo { get; set; }

    public string? QbName { get; set; }

    public int EntityId { get; set; }
}
