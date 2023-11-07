using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class KioskLocation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int LocationId { get; set; }

    public int PosLocationId { get; set; }

    /// <summary>
    /// Active/Inactive
    /// </summary>
    public bool? Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }
}
