using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserQueueGroup
{
    public uint UserId { get; set; }

    public int GroupId { get; set; }

    public int GroupIdOld { get; set; }

    public int ParentId { get; set; }

    public string Status { get; set; } = null!;

    public decimal OverrideFee { get; set; }

    public decimal OverrideEnrollmentFee { get; set; }

    public decimal TotalMembershipFee { get; set; }

    public decimal TotalEnrollmentFee { get; set; }

    public bool IsHolded { get; set; }

    public DateOnly NextBillDate { get; set; }

    public DateOnly JoinDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public string UgStatus { get; set; } = null!;

    public DateOnly ActivateOn { get; set; }

    public DateOnly? InactivateOn { get; set; }

    public DateOnly CancelOn { get; set; }

    public DateOnly HoldFrom { get; set; }

    public DateOnly HoldTo { get; set; }

    public DateOnly CanceledDate { get; set; }

    public string? CanceledReason { get; set; }

    public DateOnly ActivatedDate { get; set; }

    public DateOnly ExpiredDate { get; set; }

    public DateOnly HoldedDate { get; set; }

    public DateOnly StartBillingDate { get; set; }

    public DateOnly StopBillingDate { get; set; }

    public sbyte? HowAdded { get; set; }

    public uint AddedBy { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public int ReferedBy { get; set; }

    public decimal ReferedByValue { get; set; }

    public string ReferedByType { get; set; } = null!;

    public decimal CreditAmount { get; set; }

    public int BillTo { get; set; }

    public decimal BillToPercent { get; set; }

    public string BillToType { get; set; } = null!;

    public bool? HoldType { get; set; }

    public decimal HoldValue { get; set; }

    public bool IsSecondary { get; set; }

    public decimal MembershipDiscount { get; set; }

    public bool DiscountAsStatement { get; set; }

    public int MonthlyBillingType { get; set; }

    public DateOnly MonthlyProrateFrom { get; set; }

    public DateOnly MonthlyStartBillingFrom { get; set; }

    public int MonthlyActivateOn { get; set; }

    public int? SoldAt { get; set; }

    public int? MapRevenueTo { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
