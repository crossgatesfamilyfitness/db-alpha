using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserAuthhash
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Hash { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime Created { get; set; }

    /// <summary>
    /// URL to redirect user to upon successful authorization.
    /// </summary>
    public string RedirectToUrl { get; set; } = null!;

    public string? AuthCode { get; set; }
}
