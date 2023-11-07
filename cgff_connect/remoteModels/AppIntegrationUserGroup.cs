using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppIntegrationUserGroup
{
    public int Id { get; set; }

    public int AppIntegrationId { get; set; }

    public int GroupId { get; set; }
}
