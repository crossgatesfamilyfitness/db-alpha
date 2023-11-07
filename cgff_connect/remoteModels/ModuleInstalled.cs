using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ModuleInstalled
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ParametrsStructure { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string CreationDate { get; set; } = null!;

    public DateOnly InstallationDate { get; set; }

    public string Version { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Status { get; set; } = null!;
}
