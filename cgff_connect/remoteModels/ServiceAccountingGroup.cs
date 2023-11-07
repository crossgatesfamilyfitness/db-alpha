using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceAccountingGroup
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public int? EntityId { get; set; }

    public int? AccgroupId { get; set; }

    public virtual AccountingGroup? Accgroup { get; set; }

    public virtual AccgroupEntity? Entity { get; set; }

    public virtual ServiceType? ServiceType { get; set; }
}
