using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserBiography
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ComponentId { get; set; }

    public string? Biography { get; set; }

    public string? Experience { get; set; }

    public string? Certification { get; set; }

    public string? ContactInfo { get; set; }

    public string? BioPicture { get; set; }
}
