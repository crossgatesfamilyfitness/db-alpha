using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserCustomRegistrationFieldsValue
{
    public int UserId { get; set; }

    public int UserCustomFieldsId { get; set; }

    public int EventId { get; set; }

    public string? ValueText { get; set; }

    public double? ValueNumber { get; set; }

    public DateOnly? ValueDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
