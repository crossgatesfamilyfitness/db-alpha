using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Kitchen
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// name
    /// </summary>
    public string Name { get; set; } = null!;

    public bool Status { get; set; }
}
