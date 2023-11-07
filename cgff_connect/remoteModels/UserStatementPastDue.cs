using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserStatementPastDue
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public decimal? Current { get; set; }

    public decimal? D30 { get; set; }

    public decimal? D60 { get; set; }

    public decimal? D90 { get; set; }

    public decimal D120 { get; set; }

    public decimal? StatementBalance { get; set; }

    public decimal UnusedCredits { get; set; }

    public bool? NeedUpdate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
