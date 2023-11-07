using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Contract
{
    public uint Id { get; set; }

    public uint UserId { get; set; }

    public uint GroupId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public float ContractFee { get; set; }

    public decimal EnrollmentFee { get; set; }

    public float? OriginalFee { get; set; }

    public byte MonthCount { get; set; }

    public byte Expired { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public byte Enabled { get; set; }

    public byte Type { get; set; }

    public bool? VersionType { get; set; }

    public bool? AuditStatus { get; set; }

    public uint DocumentId { get; set; }

    public uint Status { get; set; }

    public uint RenewalTerm { get; set; }

    public uint RenewalOption { get; set; }

    public uint? ActiveMonths { get; set; }

    public bool IsQueue { get; set; }

    public int? ContractTermsId { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual ContractTerm? ContractTerms { get; set; }
}
