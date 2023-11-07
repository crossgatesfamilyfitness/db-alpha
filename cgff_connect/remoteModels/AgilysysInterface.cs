using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AgilysysInterface
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Settings { get; set; } = null!;
}
