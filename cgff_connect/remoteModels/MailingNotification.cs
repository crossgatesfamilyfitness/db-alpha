using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MailingNotification
{
    public int Id { get; set; }

    public int Notification { get; set; }

    public int Sender { get; set; }

    public int Template { get; set; }

    public bool Default { get; set; }
}
