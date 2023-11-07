using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceLocation
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public int? LocationAreaId { get; set; }

    public int? LocationRoomId { get; set; }

    public virtual LocationArea? LocationArea { get; set; }

    public virtual LocationRoom? LocationRoom { get; set; }

    public virtual ServiceType? ServiceType { get; set; }
}
