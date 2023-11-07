using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Resource
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int ResourceTypeId { get; set; }

    public int? CourtTypeId { get; set; }

    public int? CourtLocationId { get; set; }

    public decimal? Fee { get; set; }

    public bool? CanBeReserved { get; set; }

    public bool? Visible { get; set; }

    public int MaxAttendCnt { get; set; }

    public int? ResourceInfoId { get; set; }

    public bool ExternalResource { get; set; }

    public bool? BallMachine { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
