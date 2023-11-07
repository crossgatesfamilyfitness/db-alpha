using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Recurrence
{
    public uint Id { get; set; }

    public string Type { get; set; } = null!;

    public int Period { get; set; }

    public sbyte IsEndAfter { get; set; }

    public int EndAfterOccurence { get; set; }

    public sbyte IsEndBy { get; set; }

    public DateOnly? EndByDate { get; set; }

    /// <summary>
    /// No end date
    /// </summary>
    public sbyte IsPermanently { get; set; }

    public string Rule { get; set; } = null!;
}
