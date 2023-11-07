using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class EftPendingTotal
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int PayerId { get; set; }

    public int RetailerId { get; set; }

    public int EntityId { get; set; }

    public int UserContractId { get; set; }

    public decimal Amount { get; set; }

    public sbyte IsProcessing { get; set; }

    public string? UniqueHash { get; set; }
}
