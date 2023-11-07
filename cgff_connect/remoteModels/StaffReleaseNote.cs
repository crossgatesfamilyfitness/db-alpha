using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StaffReleaseNote
{
    public int Id { get; set; }

    public int StaffId { get; set; }

    public int ReleaseNoteId { get; set; }

    public DateTime RealeaseNoteDate { get; set; }
}
