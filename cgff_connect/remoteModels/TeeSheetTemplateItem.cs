using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TeeSheetTemplateItem
{
    public long Id { get; set; }

    public int TeeSheetTemplateId { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    /// <summary>
    /// tee time | shortgun | blocked time (see defined constants)
    /// </summary>
    public sbyte Type { get; set; }

    /// <summary>
    /// in minutes
    /// </summary>
    public int TeeTimeInterval { get; set; }

    /// <summary>
    /// usually 1/10 for Front 9/Back 9 (for tee time only)
    /// </summary>
    public sbyte StartHole { get; set; }

    /// <summary>
    /// 18/9 holes, see constants (for tee time only)
    /// </summary>
    public sbyte RoundType { get; set; }

    public sbyte PlayersMaxNum { get; set; }
}
