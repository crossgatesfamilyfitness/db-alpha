using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class OverriddenRegistration
{
    public int Id { get; set; }

    public DateTime PostDate { get; set; }

    public int MemberId { get; set; }

    public int StaffId { get; set; }

    public string Class { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public int EntityId { get; set; }
}
