using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OauthClientScope
{
    public uint Id { get; set; }

    public string ClientId { get; set; } = null!;

    public uint ScopeId { get; set; }

    public virtual OauthClient Client { get; set; } = null!;

    public virtual OauthScope Scope { get; set; } = null!;
}
