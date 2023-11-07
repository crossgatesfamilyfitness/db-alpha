using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class UserBalance
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int Type { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public float Balance { get; set; }

    public int ViewHidden { get; set; }
}
