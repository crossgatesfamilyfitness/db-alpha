using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserQueueGroupSale
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public uint GroupId { get; set; }

    public uint GroupIdOld { get; set; }

    public uint SalesId { get; set; }

    public uint Order { get; set; }

    public DateOnly? AddedDate { get; set; }

    public DateOnly? RemovedDate { get; set; }

    public bool Removed { get; set; }
}
