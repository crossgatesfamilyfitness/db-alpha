using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailAttachment
{
    public uint Id { get; set; }

    public uint? MailId { get; set; }

    public uint? TemplateId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string FileName { get; set; } = null!;
}
