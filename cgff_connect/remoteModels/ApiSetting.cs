using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ApiSetting
{
    public long Id { get; set; }

    public string OauthClientId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Data { get; set; }
}
