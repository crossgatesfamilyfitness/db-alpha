using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserStatementAgingBalance
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public decimal AgingBalance { get; set; }

    public decimal TotalBalance { get; set; }

    public uint AgingDays { get; set; }

    public decimal StatementBalance { get; set; }

    public decimal UnusedCredits { get; set; }

    public bool? NeedUpdate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
