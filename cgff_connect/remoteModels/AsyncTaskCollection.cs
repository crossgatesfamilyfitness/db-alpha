using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AsyncTaskCollection
{
    public uint Id { get; set; }

    public string? Type { get; set; }

    public int? CronId { get; set; }

    public ulong? TaskId { get; set; }

    public sbyte Status { get; set; }

    public int StatusCheckCount { get; set; }

    public string ChunkBase { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime UpdatedTime { get; set; }
}
