using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RevenueGroup
{
    public int Id { get; set; }

    public decimal TotalAmount { get; set; }

    public int Count { get; set; }

    public string Period { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public int? FromGroup { get; set; }

    public int? ToGroup { get; set; }

    public ulong SubjectId { get; set; }

    public int? GroupId { get; set; }

    public sbyte? GroupType { get; set; }

    public int EntityId { get; set; }

    public int? UserId { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Dates { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<RevenueRecognition> RevenueRecognitions { get; } = new List<RevenueRecognition>();
}
