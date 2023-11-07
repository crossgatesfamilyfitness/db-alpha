using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChildcareReservationRuleGroup
{
    public int GroupId { get; set; }

    public uint ReservationRuleId { get; set; }

    public virtual ChildcareReservationRule ReservationRule { get; set; } = null!;
}
