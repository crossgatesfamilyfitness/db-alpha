using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailingTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Subject { get; set; } = null!;

    public string? Recipients { get; set; }

    public string Type { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string Variables { get; set; } = null!;

    public string Status { get; set; } = null!;
}
