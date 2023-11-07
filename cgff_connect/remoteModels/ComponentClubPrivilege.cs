using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ComponentClubPrivilege
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ComponentClubName { get; set; } = null!;

    public int ComponentId { get; set; }

    public bool ClubServiceSelectShow { get; set; }

    public bool ReportPlayerRatingClasses { get; set; }

    public bool ClassRegistrationSelectShow { get; set; }
}
