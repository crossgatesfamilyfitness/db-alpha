using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Deprecated, delete after CA-4471
/// </summary>
public partial class CaMenuItemPermission
{
    public int Id { get; set; }

    public int MenuItemId { get; set; }

    public int GroupId { get; set; }

    public string PermissionType { get; set; } = null!;
}
