using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

/// <summary>
/// Club account shift4
/// </summary>
public partial class ClubAccountShift4
{
    /// <summary>
    /// id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Retailer
    /// </summary>
    public int CcRetailer { get; set; }

    /// <summary>
    /// Authorization token
    /// </summary>
    public string Authtoken { get; set; } = null!;

    /// <summary>
    /// Client GUID
    /// </summary>
    public string ClientGuid { get; set; } = null!;

    /// <summary>
    /// Access token
    /// </summary>
    public string AccessToken { get; set; } = null!;

    /// <summary>
    /// Token Serial Number
    /// </summary>
    public string TokenSerialNumber { get; set; } = null!;
}
