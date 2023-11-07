using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TeeTime
{
    public long Id { get; set; }

    /// <summary>
    /// tee time | shortgun | blocked time (see defined constants)
    /// </summary>
    public sbyte Type { get; set; }

    public int TeeSheetId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    /// <summary>
    /// number of players already registered in this time slot
    /// </summary>
    public sbyte PlayersNum { get; set; }

    /// <summary>
    /// maximum number of players allowed for online registration
    /// </summary>
    public sbyte PlayersMaxNum { get; set; }

    public int EntityId { get; set; }

    public int ResourceId { get; set; }

    /// <summary>
    /// 18/9 holes round, see constants (is used when create tee time reservation)
    /// </summary>
    public sbyte RoundType { get; set; }

    /// <summary>
    /// 1 for Front 9, 10 for Back 9 etc. (is used when create tee time reservation)
    /// </summary>
    public sbyte StartHole { get; set; }

    /// <summary>
    /// 1 - active, 2 - squeeze, 3 - canceled
    /// </summary>
    public bool? Status { get; set; }

    public decimal GreenFee { get; set; }

    public decimal GolfCartFee { get; set; }
}
