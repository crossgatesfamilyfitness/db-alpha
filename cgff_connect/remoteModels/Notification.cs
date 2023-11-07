using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Notification
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public uint? Sort { get; set; }

    public int? ComponentId { get; set; }

    public bool IsStaff { get; set; }

    public bool HasChildren { get; set; }

    public bool IsHidden { get; set; }

    public int? ParentId { get; set; }

    public bool SmsSupport { get; set; }

    public bool PushSupport { get; set; }
}
