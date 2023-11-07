using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BookerSetting
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Account { get; set; } = null!;

    public string AuthLogin { get; set; } = null!;

    public string AuthPassword { get; set; } = null!;

    public string Clientid { get; set; } = null!;

    public string Clientsecret { get; set; } = null!;

    public string Locationid { get; set; } = null!;

    public string Tenderid { get; set; } = null!;

    public int AccGroupId { get; set; }

    public string Prefix { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Logs { get; set; }

    public bool DefaultLocation { get; set; }
}
