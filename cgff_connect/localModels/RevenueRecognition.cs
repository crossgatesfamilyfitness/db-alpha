using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class RevenueRecognition
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public DateOnly? SupposedDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public DateTime Time { get; set; }

    public int UserId { get; set; }

    public int SubjectType { get; set; }

    public ulong SubjectId { get; set; }

    public int FromGroup { get; set; }

    public int ToGroup { get; set; }

    public float Amount { get; set; }

    public decimal? AmountPerDay { get; set; }

    public string? Description { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public int? RevenueGroupId { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
