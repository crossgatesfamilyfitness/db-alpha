using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OauthClient
{
    public string Id { get; set; } = null!;

    public string? Secret { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string AlgorithmType { get; set; } = null!;

    public virtual ICollection<OauthClientScope> OauthClientScopes { get; } = new List<OauthClientScope>();
}
