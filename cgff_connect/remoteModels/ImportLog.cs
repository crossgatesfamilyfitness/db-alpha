using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportLog
{
    public uint InternalId { get; set; }

    public DateTime Inserted { get; set; }

    /// <summary>
    /// User Running Import
    /// </summary>
    public string UserName { get; set; } = null!;

    public string? ScriptPath { get; set; }

    /// <summary>
    /// Required - enum(&apos;error&apos;,&apos;info&apos;)
    /// </summary>
    public string MessageType { get; set; } = null!;

    public string Message { get; set; } = null!;
}
