using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceStaff
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public int? UserId { get; set; }

    public int? GroupId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual ServiceType? ServiceType { get; set; }
}
