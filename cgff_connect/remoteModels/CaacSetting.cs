using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CaacSetting
{
    public int Id { get; set; }

    public string Param { get; set; } = null!;

    public int IntValue { get; set; }

    public string VarcharValue { get; set; } = null!;

    public string TextValue { get; set; } = null!;
}
