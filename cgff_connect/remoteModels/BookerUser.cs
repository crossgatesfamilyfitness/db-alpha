using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BookerUser
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public long? BookerCustomerId { get; set; }

    public string BookerCustomerGuid { get; set; } = null!;
}
