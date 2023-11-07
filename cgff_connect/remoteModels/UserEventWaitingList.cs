using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserEventWaitingList
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public int UserId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
