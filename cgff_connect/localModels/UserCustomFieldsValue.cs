using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class UserCustomFieldsValue
{
    public int UserId { get; set; }

    public int FieldId { get; set; }

    public string? ValueText { get; set; }

    public double? ValueNumber { get; set; }

    public DateOnly? ValueDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
