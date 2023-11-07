using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PackageCalendar
{
    public int Id { get; set; }

    public int PackageId { get; set; }

    public int CalendarId { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
