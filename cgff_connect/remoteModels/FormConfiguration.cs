using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Table for forms configuration data
/// </summary>
public partial class FormConfiguration
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Fields { get; set; }
}
