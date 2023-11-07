using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserFavoriteLocation
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    /// <summary>
    /// accgroup_entity_id
    /// </summary>
    public uint LocationId { get; set; }
}
