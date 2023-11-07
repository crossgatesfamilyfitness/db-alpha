using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PackageRate
{
    public int Id { get; set; }

    public int PackageId { get; set; }

    public int Qnt { get; set; }

    public decimal Price { get; set; }

    public bool? Status { get; set; }
}
