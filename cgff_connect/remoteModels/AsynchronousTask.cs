using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AsynchronousTask
{
    public ulong Id { get; set; }

    public string Type { get; set; } = null!;

    public sbyte Status { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime UpdatedTime { get; set; }

    public string? Params { get; set; }

    public int? RunAsUser { get; set; }

    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Log_Track stack on the moment the record was created
    /// </summary>
    public string? LogTrack { get; set; }

    public string ProcessorType { get; set; } = null!;

    /// <summary>
    /// Task group
    /// </summary>
    public string? Chunk { get; set; }

    public uint? AsyncCollectionId { get; set; }

    public string Category { get; set; } = null!;
}
