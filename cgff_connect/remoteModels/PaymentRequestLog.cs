using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PaymentRequestLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string ApiMethod { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Request { get; set; } = null!;

    public string? Response { get; set; }

    public string ResponseData { get; set; } = null!;

    public string RequestData { get; set; } = null!;

    public string Host { get; set; } = null!;

    public string? ApiErrorCode { get; set; }

    public string? ApiErrorMessage { get; set; }

    public string? SystemError { get; set; }

    public string? CallStack { get; set; }
}
