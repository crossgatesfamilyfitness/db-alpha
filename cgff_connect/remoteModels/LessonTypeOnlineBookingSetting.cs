using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class LessonTypeOnlineBookingSetting
{
    public uint Id { get; set; }

    public int LessonTypeId { get; set; }

    public int ComponentId { get; set; }

    public uint OnlineBookingSettingsId { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public string? LastTrack { get; set; }

    public virtual Component Component { get; set; } = null!;

    public virtual LessonType LessonType { get; set; } = null!;

    public virtual OnlineBookingSetting OnlineBookingSettings { get; set; } = null!;
}
