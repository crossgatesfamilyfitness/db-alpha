﻿using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OauthSession
{
    public uint Id { get; set; }

    public int UserId { get; set; }

    public string ClientId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
