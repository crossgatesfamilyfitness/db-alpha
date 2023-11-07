using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class BankAccountNoc
{
    /// <summary>
    /// id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// user ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// payment ID
    /// </summary>
    public string PaymentId { get; set; } = null!;

    /// <summary>
    /// date
    /// </summary>
    public DateTime NocDate { get; set; }

    /// <summary>
    /// change code
    /// </summary>
    public string NocChangeCode { get; set; } = null!;

    /// <summary>
    /// change description
    /// </summary>
    public string? NocChangeDescription { get; set; }

    /// <summary>
    /// account type
    /// </summary>
    public string AccountType { get; set; } = null!;

    /// <summary>
    /// routing number
    /// </summary>
    public string RoutingNumber { get; set; } = null!;

    /// <summary>
    /// real routing number
    /// </summary>
    public string RealRoutingNumber { get; set; } = null!;

    /// <summary>
    /// accoun number
    /// </summary>
    public string AccountNumber { get; set; } = null!;

    /// <summary>
    /// real accounting number
    /// </summary>
    public string RealAccountNumber { get; set; } = null!;

    /// <summary>
    /// retailer ID
    /// </summary>
    public int RetailerId { get; set; }

    /// <summary>
    /// updated data numbers
    /// </summary>
    public bool Updated { get; set; }

    /// <summary>
    /// user bank account id
    /// </summary>
    public int? UserBankAccountId { get; set; }
}
