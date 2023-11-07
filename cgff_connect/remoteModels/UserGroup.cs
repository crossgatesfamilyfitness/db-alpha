using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserGroup
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    public int GroupId { get; set; }

    public float OverrideFee { get; set; }

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

    public string CanceledReason { get; set; } = null!;

    public DateOnly ActivatedDate { get; set; }

    public DateOnly ExpiredDate { get; set; }

    public DateOnly HoldedDate { get; set; }

    public string HoldReason { get; set; } = null!;

    public DateOnly StartBillingDate { get; set; }

    public DateOnly StopBillingDate { get; set; }

    public sbyte? HowAdded { get; set; }

    public uint AddedBy { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public int ReferedBy { get; set; }

    public float ReferedByValue { get; set; }

    public string ReferedByType { get; set; } = null!;

    public float CreditAmount { get; set; }

    public int BillTo { get; set; }

    public float BillToPercent { get; set; }

    public string BillToType { get; set; } = null!;

    public bool? HoldType { get; set; }

    public float HoldValue { get; set; }

    public float MembershipDiscount { get; set; }

    public bool DiscountAsStatement { get; set; }

    public bool IsSecondary { get; set; }

    public int AddonResourceId { get; set; }

    public int BillingTypeGroupId { get; set; }

    public bool IsMembershipAddon { get; set; }

    public DateOnly? AddonEndDate { get; set; }

    public int? SoldAt { get; set; }

    public int? MapRevenueTo { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public int MonthlyBillingType { get; set; }

    public DateOnly MonthlyProrateFrom { get; set; }

    public DateOnly MonthlyStartBillingFrom { get; set; }

    public int MonthlyActivateOn { get; set; }
}
