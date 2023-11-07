using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppIntegration
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Icon { get; set; }

    public string LinkType { get; set; } = null!;

    public string? WebLink { get; set; }

    public string? IosLink { get; set; }

    public string? AndroidLink { get; set; }

    public bool IsActive { get; set; }

    public bool IsSelectedAllLocations { get; set; }

    public bool IsSelectedAllGroups { get; set; }

    public int SortOrder { get; set; }

    public string? PostParams { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
