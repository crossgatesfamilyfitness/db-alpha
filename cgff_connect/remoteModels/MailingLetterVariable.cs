using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailingLetterVariable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Status { get; set; } = null!;

    public bool IsAvailableForMails { get; set; }
}
