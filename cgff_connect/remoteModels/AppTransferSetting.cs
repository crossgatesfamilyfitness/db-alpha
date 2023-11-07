using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class AppTransferSetting
{
    public int Id { get; set; }

    public string OldAppClientId { get; set; } = null!;

    public string NewAppName { get; set; } = null!;

    public string LinkForNewApp { get; set; } = null!;

    public string EmailSubject { get; set; } = null!;

    public string? EmailBody { get; set; }

    public string? ErrorMessageText { get; set; }

    public bool Enabled { get; set; }
}
