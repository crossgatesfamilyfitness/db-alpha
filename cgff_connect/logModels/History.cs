using System;
using System.Collections.Generic;

namespace cgff_connect.logModels;

public partial class History
{
    public uint Id { get; set; }

    public string Action { get; set; } = null!;

    public uint? EventTypeId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public uint ModifiedBy { get; set; }

    public string Title { get; set; } = null!;

    public uint? KnownResource { get; set; }

    public string LogTransactionId { get; set; } = null!;
}
