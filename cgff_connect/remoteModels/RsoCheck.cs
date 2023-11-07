using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RsoCheck
{
    public int Id { get; set; }

    public int UserId { get; set; }

    /// <summary>
    /// Start time of check of user
    /// </summary>
    public DateTime Date { get; set; }

    public string Status { get; set; } = null!;

    public string ErrorMessage { get; set; } = null!;
}
