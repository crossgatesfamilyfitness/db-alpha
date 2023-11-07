using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksIdent
{
    public uint QuickbooksIdentId { get; set; }

    public string QbUsername { get; set; } = null!;

    public string QbObject { get; set; } = null!;

    public string UniqueId { get; set; } = null!;

    public string QbIdent { get; set; } = null!;

    public string Editsequence { get; set; } = null!;

    public string? Extra { get; set; }

    public DateTime MapDatetime { get; set; }
}
