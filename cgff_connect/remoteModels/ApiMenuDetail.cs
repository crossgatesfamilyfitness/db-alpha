using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ApiMenuDetail
{
    public int Id { get; set; }

    public string MenuItem { get; set; } = null!;

    public string DisplayName { get; set; } = null!;
}
