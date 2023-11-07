using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EventCustomRegistrationField
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public int UserCustomFieldsId { get; set; }

    public bool IsRequired { get; set; }

    public virtual UserCustomField UserCustomFields { get; set; } = null!;
}
