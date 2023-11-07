using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Holds letter templates for notifications per component.
/// </summary>
public partial class MailingNotificationTemplate
{
    public int Id { get; set; }

    public int MailingNotificationId { get; set; }

    public int ComponentId { get; set; }

    public int MailingTemplateId { get; set; }
}
