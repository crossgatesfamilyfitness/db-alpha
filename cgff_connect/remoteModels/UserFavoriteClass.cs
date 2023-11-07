using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserFavoriteClass
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    /// <summary>
    /// event id with type Group Activity
    /// </summary>
    public uint ClassId { get; set; }
}
