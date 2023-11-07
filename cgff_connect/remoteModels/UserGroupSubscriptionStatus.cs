using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroupSubscriptionStatus
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? GroupId { get; set; }

    public int? UserGroupSubscriptionId { get; set; }

    public int? UserGroupSubscriptionActionId { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public bool? LastInDay { get; set; }

    public string Status { get; set; } = null!;

    public string HoldReason { get; set; } = null!;

    public string CancelReason { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
