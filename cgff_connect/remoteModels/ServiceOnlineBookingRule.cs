using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceOnlineBookingRule
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public bool UseCategoryDefaults { get; set; }

    public bool CanBeBookedOnline { get; set; }

    public int MinBookingLeadTime { get; set; }

    public string MinBookingLeadTimeType { get; set; } = null!;

    public int MaxBookingLeadTime { get; set; }

    public string MaxBookingLeadTimeType { get; set; } = null!;

    public int BookingIntervalMinutes { get; set; }

    public virtual ServiceType? ServiceType { get; set; }
}
