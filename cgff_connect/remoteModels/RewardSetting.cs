using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RewardSetting
{
    public int Id { get; set; }

    public decimal Ratio { get; set; }

    public string Restrictions { get; set; } = null!;

    public int Expire { get; set; }

    public sbyte ExpireType { get; set; }

    public int Liability { get; set; }
}
