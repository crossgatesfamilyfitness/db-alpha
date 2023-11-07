using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventPrice
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public string PriceType { get; set; } = null!;

    public decimal Price { get; set; }
}
