using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BookerCustomField
{
    public int Id { get; set; }

    public int BookerFieldId { get; set; }

    public string CaLinkedField { get; set; } = null!;

    public string Name { get; set; } = null!;
}
