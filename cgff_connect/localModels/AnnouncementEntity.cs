using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class AnnouncementEntity
{
    public uint Id { get; set; }

    public uint AnnouncementId { get; set; }

    public int EntityId { get; set; }
}
