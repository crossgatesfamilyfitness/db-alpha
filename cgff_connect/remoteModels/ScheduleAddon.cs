using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ScheduleAddon
{
    public int Id { get; set; }

    public ulong? ScheduleId { get; set; }

    public int? AddonId { get; set; }

    public int UserId { get; set; }

    public decimal Count { get; set; }

    /// <summary>
    /// has default value been selected
    /// </summary>
    public bool? IsDefault { get; set; }

    public decimal Price { get; set; }

    /// <summary>
    /// payment status; values: 0 - free, 1 - paid, 2 - unpaid
    /// </summary>
    public bool? PaymentStatus { get; set; }
}
