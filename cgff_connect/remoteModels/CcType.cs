﻿using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CcType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Status { get; set; }
}
