using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CourtLocation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ComponentId { get; set; }

    public int EntityId { get; set; }

    public bool? Status { get; set; }

    public int? CourtLocationTypeId { get; set; }

    /// <summary>
    /// Must be equal to 1 if Terms &amp; Conditions are required to be accepted during booking.
    /// </summary>
    public bool IsTermsRequired { get; set; }

    /// <summary>
    /// Terms &amp; Conditions to be displayed and accepted during booking.
    /// </summary>
    public string? TermsText { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual ICollection<CourtLocationComponent> CourtLocationComponents { get; } = new List<CourtLocationComponent>();
}
