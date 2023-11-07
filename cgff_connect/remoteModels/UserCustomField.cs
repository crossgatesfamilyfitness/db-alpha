using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserCustomField
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string UsedFor { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public sbyte InUse { get; set; }

    public int Order { get; set; }

    public string Params { get; set; } = null!;

    public DateTime UtcTimestamp { get; set; }

    public virtual ICollection<EventCustomRegistrationField> EventCustomRegistrationFields { get; } = new List<EventCustomRegistrationField>();
}
