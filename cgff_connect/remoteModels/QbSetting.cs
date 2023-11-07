using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class QbSetting
{
    public int Id { get; set; }

    public string User { get; set; } = null!;

    public string BankAccount { get; set; } = null!;
}
