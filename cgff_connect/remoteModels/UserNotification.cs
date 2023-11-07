using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserNotification
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int Notification { get; set; }

    public int Sender { get; set; }
}
