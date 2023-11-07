using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailingNotice
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public string Emails { get; set; } = null!;

    public bool? Enabled { get; set; }

    public int Template { get; set; }
}
