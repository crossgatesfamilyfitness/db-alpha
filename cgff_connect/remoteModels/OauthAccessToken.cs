using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OauthAccessToken
{
    public string Id { get; set; } = null!;

    public uint SessionId { get; set; }

    public DateTime ExpireTime { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? TokenSecret { get; set; }

    public string IssuedBy { get; set; } = null!;

    public string? RefreshToken { get; set; }

    public string? Scopes { get; set; }

    public string AlgorithmType { get; set; } = null!;

    public string? PhpSession { get; set; }
}
