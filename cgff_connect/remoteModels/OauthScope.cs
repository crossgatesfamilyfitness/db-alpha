using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OauthScope
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public bool AllowUnauthenticatedUsers { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<OauthClientScope> OauthClientScopes { get; } = new List<OauthClientScope>();
}
