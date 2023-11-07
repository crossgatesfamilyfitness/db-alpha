using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MembershipRejected
{
    public ulong Id { get; set; }

    public int UserId { get; set; }

    public int GroupId { get; set; }

    public long MembershipId { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public DateOnly? StartDate { get; set; }
}
