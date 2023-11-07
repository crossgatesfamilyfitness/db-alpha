using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ParentId { get; set; }

    public string Type { get; set; } = null!;

    public string? FamilyType { get; set; }

    public string BillingType { get; set; } = null!;

    public short CycleDuration { get; set; }

    public string? CycleType { get; set; }

    public bool PaymentRequired { get; set; }

    public bool PayNow { get; set; }

    public string SysName { get; set; } = null!;

    public float MemberFee { get; set; }

    public byte BillingDay { get; set; }

    public string MemberFeeType { get; set; } = null!;

    public float EnrollmentFee { get; set; }

    public bool? DisplayOnProfile { get; set; }

    public byte DisplayOnSignin { get; set; }

    public byte AvailableOnStaffSchedule { get; set; }

    public bool IsFamily { get; set; }

    public int Priority { get; set; }

    public string SystemType { get; set; } = null!;

    public bool CustomPeriod { get; set; }

    public string StartDate { get; set; } = null!;

    public string EndDate { get; set; } = null!;

    public bool ShowOnMembership { get; set; }

    public byte ShowOnProspect { get; set; }

    public bool System { get; set; }

    public int ComponentId { get; set; }

    public bool? NoGuestFee { get; set; }

    public bool? NoGuestFeeChild { get; set; }

    public sbyte GroupType { get; set; }

    public bool DeferredRevenue { get; set; }

    public bool AutoRenew { get; set; }

    public bool AutoEnroll { get; set; }

    public bool AutoCancel { get; set; }

    public int RenewBefore { get; set; }

    public bool ScheduleShow { get; set; }

    public bool PosAvailable { get; set; }

    public bool AnnualMaintenanceFee { get; set; }

    public float PAmount { get; set; }

    public string PDescription { get; set; } = null!;

    public string PBillingType { get; set; } = null!;

    public sbyte PBillingMonth { get; set; }

    public sbyte PBillingDateMonth { get; set; }

    public sbyte PBillingDateDay { get; set; }

    public bool BillGuestFee { get; set; }

    public bool UseNonmemberFee { get; set; }

    public string? Description { get; set; }

    public bool IsOnlineRegistration { get; set; }

    public bool? HoldType { get; set; }

    public float HoldValue { get; set; }

    public bool IsResource { get; set; }

    public byte AllowFeeProration { get; set; }

    public bool ProrateLastMonth { get; set; }

    public byte AvailableForSale { get; set; }

    public bool AvailableForOnlineSale { get; set; }

    public byte UseSaleSpecificDate { get; set; }

    public DateOnly? SalesStartDate { get; set; }

    public DateOnly? SalesEndDate { get; set; }

    public uint? MembershipTypeId { get; set; }

    public bool AutomaticApproval { get; set; }

    public bool OnlineMembershipProration { get; set; }

    public string AddonType { get; set; } = null!;

    public string? StatementDescription { get; set; }

    public string? OnlineDescription { get; set; }

    public bool ShowOnCheckin { get; set; }

    public string? ResourceName { get; set; }

    public byte ContractEnabled { get; set; }

    public uint ContractAgreementTerm { get; set; }

    public uint ContractRenewalTerm { get; set; }

    public uint ContractRenewalOption { get; set; }

    public byte HasAdditionalCharges { get; set; }

    public uint ContractLockRate { get; set; }

    public short MaxDependents { get; set; }

    public int DurationValue { get; set; }

    public string DurationType { get; set; } = null!;

    public int? ContractTermsId { get; set; }

    public string RevenueMapping { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LastTrack { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual ContractTerm? ContractTerms { get; set; }

    public virtual MembershipType? MembershipType { get; set; }
}
