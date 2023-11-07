using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventCustomFee
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public uint EventId { get; set; }

    public decimal? ActivityFee { get; set; }

    public decimal? SessionFee { get; set; }

    public decimal? PerTimeFee { get; set; }

    public decimal? RegistrationFee { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
