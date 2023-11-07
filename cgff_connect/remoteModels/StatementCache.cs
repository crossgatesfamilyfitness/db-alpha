using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class StatementCache
{
    public ulong Id { get; set; }

    public DateTime? TimeTo { get; set; }

    public DateTime CacheDate { get; set; }

    public string Hash { get; set; } = null!;

    public int UserId { get; set; }

    public DateOnly? DateTo { get; set; }

    public string ContractNum { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public decimal Current { get; set; }

    public decimal D30 { get; set; }

    public decimal D60 { get; set; }

    public decimal D90 { get; set; }

    public decimal D120 { get; set; }

    public decimal Credit { get; set; }

    public decimal LateFee { get; set; }

    public decimal StatementBalance { get; set; }

    public uint CumulativeAging { get; set; }

    public string Status { get; set; } = null!;

    public string HouseCharge { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string MemberFirstName { get; set; } = null!;

    public string MemberLastName { get; set; } = null!;

    public sbyte RowType { get; set; }

    public bool? CacheStatus { get; set; }
}
