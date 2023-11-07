using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class DcsEmailRecord
{
    public uint Id { get; set; }

    /// <summary>
    /// User ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// External member ID
    /// </summary>
    public string ExternalMemberId { get; set; } = null!;

    /// <summary>
    /// email address
    /// </summary>
    public string EmailAddress { get; set; } = null!;

    /// <summary>
    /// 1=&gt;success or 0=&gt;failure
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// from XX01-15, XD01-03, XM01-03, XS01-07
    /// </summary>
    public string ResponseCode { get; set; } = null!;

    /// <summary>
    /// response code description
    /// </summary>
    public string ResponseDescription { get; set; } = null!;

    /// <summary>
    /// created datetime
    /// </summary>
    public DateTime CreatedDate { get; set; }
}
