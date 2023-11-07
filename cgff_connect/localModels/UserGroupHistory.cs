using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class UserGroupHistory
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    public int GroupId { get; set; }

    public DateTime DateTime { get; set; }

    public DateOnly DateFrom { get; set; }

    public DateOnly DateTo { get; set; }

    public int ParentId { get; set; }

    public string Linked { get; set; } = null!;

    public bool IsNew { get; set; }

    public int GroupIdOld { get; set; }

    public int GroupIdNew { get; set; }

    public decimal TotalMembershipFee { get; set; }

    public decimal TotalEnrollmentFee { get; set; }

    public bool IsHolded { get; set; }

    public DateOnly NextBillDate { get; set; }

    public DateOnly JoinDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public DateOnly ExpiredDate { get; set; }

    public string UgStatus { get; set; } = null!;

    public DateOnly HoldFrom { get; set; }

    public DateOnly HoldTo { get; set; }

    public DateOnly HoldedDate { get; set; }

    public string HoldReason { get; set; } = null!;

    public bool? HoldType { get; set; }

    public decimal HoldValue { get; set; }

    public bool Holdedplus { get; set; }

    public bool Holdedminus { get; set; }

    public bool Reactivate { get; set; }

    public bool Renewed { get; set; }

    public string UgStatusOld { get; set; } = null!;

    public bool IsMembershipAddon { get; set; }

    public int AddonResourceId { get; set; }

    public int BillingTypeGroupId { get; set; }

    public bool MarkIsNew { get; set; }

    public DateOnly CancelOn { get; set; }

    public DateOnly CanceledDate { get; set; }

    public string CanceledReason { get; set; } = null!;

    public DateOnly StartBillingDate { get; set; }

    public DateOnly StopBillingDate { get; set; }

    public bool? IsLastInDay { get; set; }

    public int ReferedBy { get; set; }

    public decimal ReferedByValue { get; set; }

    public string ReferedByType { get; set; } = null!;

    public string? MembershipSales { get; set; }

    public string? ReferralSource { get; set; }

    public int ReferringMemberId { get; set; }

    public bool Hide { get; set; }

    public int ModifiedBy { get; set; }

    public string? MembershipGoals { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
