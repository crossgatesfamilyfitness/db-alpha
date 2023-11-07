using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class CreditCardGatewayLog
{
    public int Id { get; set; }

    public string? Hash { get; set; }

    public int? UserId { get; set; }

    public string? ClientId { get; set; }

    public string Endpoint { get; set; } = null!;

    /// <summary>
    /// json of input data
    /// </summary>
    public string? Request { get; set; }

    /// <summary>
    /// json of output data
    /// </summary>
    public string? Response { get; set; }

    public DateTime? Date { get; set; }

    public string? Ip { get; set; }
}
