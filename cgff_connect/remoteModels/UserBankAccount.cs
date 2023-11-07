using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserBankAccount
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; } = null!;

    public string CheckingAccountNumber { get; set; } = null!;

    public string RealCheckingAccountNumber { get; set; } = null!;

    public string RoutingNumber { get; set; } = null!;

    public string RealRoutingNumber { get; set; } = null!;

    public string? PaymentProcessorUniqueId { get; set; }

    public string BankName { get; set; } = null!;

    public string BankState { get; set; } = null!;

    public string BankCountry { get; set; } = null!;

    public bool? BankAccountType { get; set; }

    public bool IsPrimary { get; set; }

    public DateTime CreatedDate { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public string BankCity { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }
}
