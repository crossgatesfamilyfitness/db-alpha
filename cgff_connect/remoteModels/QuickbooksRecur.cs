using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QuickbooksRecur
{
    public uint QuickbooksRecurId { get; set; }

    public string QbUsername { get; set; } = null!;

    public string QbAction { get; set; } = null!;

    public string Ident { get; set; } = null!;

    public string? Extra { get; set; }

    public string? Qbxml { get; set; }

    public uint? Priority { get; set; }

    public uint RunEvery { get; set; }

    public uint RecurLasttime { get; set; }

    public DateTime EnqueueDatetime { get; set; }
}
