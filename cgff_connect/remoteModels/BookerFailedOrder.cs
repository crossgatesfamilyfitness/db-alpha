using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BookerFailedOrder
{
    public int Id { get; set; }

    public string OrderId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? OrderInfo { get; set; }

    public DateTime Date { get; set; }

    public string Reason { get; set; } = null!;
}
