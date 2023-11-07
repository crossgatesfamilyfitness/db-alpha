using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailingTheme
{
    public uint Id { get; set; }

    public int? ParentId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }
}
