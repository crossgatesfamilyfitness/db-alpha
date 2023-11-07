using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChildcareReservationRule
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public short ReservationLimit { get; set; }

    public short ReservationLimitMin { get; set; }

    public short DailyTimeLimit { get; set; }

    public short DailyTimeLimitMin { get; set; }

    public decimal? AgeFrom { get; set; }

    public decimal? AgeTo { get; set; }

    public ushort ReserveDaysAdvanceFrom { get; set; }

    public int ReserveDaysAdvance { get; set; }

    public int MaxPendingReservations { get; set; }

    public string StatementDescription { get; set; } = null!;

    public string RuleType { get; set; } = null!;

    public virtual ICollection<ChildcareReservationRuleGroup> ChildcareReservationRuleGroups { get; } = new List<ChildcareReservationRuleGroup>();
}
