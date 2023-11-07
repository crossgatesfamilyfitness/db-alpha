using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserContract
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? ParentId { get; set; }

    public int? DocumentId { get; set; }

    public int? BaseAgreementId { get; set; }

    public string Type { get; set; } = null!;

    public string AuditStatus { get; set; } = null!;

    public string? PaymentType { get; set; }

    public int? PaymentId { get; set; }

    public DateOnly CreateDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool Signed { get; set; }

    public bool? IsActive { get; set; }

    public string Reason { get; set; } = null!;

    public string? Note { get; set; }

    public string? Term { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
