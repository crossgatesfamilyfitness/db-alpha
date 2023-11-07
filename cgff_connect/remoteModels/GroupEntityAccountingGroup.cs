using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupEntityAccountingGroup
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? EntityId { get; set; }

    public int? BaseAccountingGroupId { get; set; }

    public int? EnrollmentAccountingGroupId { get; set; }

    public int? HoldAccountingGroupId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
