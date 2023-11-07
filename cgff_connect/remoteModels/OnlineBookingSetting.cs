using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OnlineBookingSetting
{
    public uint Id { get; set; }

    public int ComponentId { get; set; }

    public string Title { get; set; } = null!;

    public string Settings { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public string? LastTrack { get; set; }

    public virtual Component Component { get; set; } = null!;

    public virtual ICollection<LessonTypeOnlineBookingSetting> LessonTypeOnlineBookingSettings { get; } = new List<LessonTypeOnlineBookingSetting>();
}
