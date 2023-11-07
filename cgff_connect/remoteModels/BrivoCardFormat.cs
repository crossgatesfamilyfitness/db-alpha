using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BrivoCardFormat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CardNumberFieldId { get; set; } = null!;

    public string FacilityCodeFieldId { get; set; } = null!;
}
