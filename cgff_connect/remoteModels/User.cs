using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Password { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public bool? SendMail { get; set; }

    public string? ELogin { get; set; }

    public string? EPass { get; set; }

    public string? AccountNum { get; set; }

    public string? AdditionalEmails { get; set; }

    public int? ParentId { get; set; }

    public int PrimaryId { get; set; }

    public string? ContractNum { get; set; }

    public string Salutation { get; set; } = null!;

    public int? Rep { get; set; }

    public sbyte? Sex { get; set; }

    public DateOnly? BirthDate { get; set; }

    public decimal Age { get; set; }

    public int MembershipType { get; set; }

    public DateOnly? Joined { get; set; }

    public DateOnly? Expired { get; set; }

    public DateOnly? Cancelled { get; set; }

    public int CreditLimit { get; set; }

    public int LateFeeExempt { get; set; }

    public string Status { get; set; } = null!;

    /// <summary>
    /// If user is both staff and member, we set role to Staff, Guest is when he is neither Staff or Member.
    /// </summary>
    public string Role { get; set; } = null!;

    public string? StreetAddress { get; set; }

    public string? StreetAddress2 { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string CountryCode { get; set; } = null!;

    /// <summary>
    /// if 1 address updated by dcs elseif 2 address acknowledge by staff elseif 3 exclude address update by dcs
    /// </summary>
    public sbyte? DcsAddrStatus { get; set; }

    public bool TaxExempt { get; set; }

    public string? Filename { get; set; }

    public string? DriversLicense { get; set; }

    public string? RealDriversLicense { get; set; }

    public string? DriversLicenseState { get; set; }

    public string? HouseCharge { get; set; }

    public int PosHouseCharge { get; set; }

    public bool? Trade { get; set; }

    public DateOnly? RegisterDate { get; set; }

    public DateOnly? LastVisitDate { get; set; }

    public bool Viewed { get; set; }

    public bool IsGlobal { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public string? CancelledReason { get; set; }

    public bool Activated { get; set; }

    public string UnsubscribeCode { get; set; } = null!;

    public string DeliveryMethod { get; set; } = null!;

    public int GuestVisits { get; set; }

    public bool MenuCollapsed { get; set; }

    public bool EmailNotConfirmed { get; set; }

    public int PosId { get; set; }

    public float Balance { get; set; }

    public DateOnly BalanceTill { get; set; }

    public bool FamilyAddrType { get; set; }

    public string? ReferralSource { get; set; }

    public bool? Confidence { get; set; }

    public int? ReferringMemberId { get; set; }

    /// <summary>
    /// home club
    /// </summary>
    public int EntityId { get; set; }

    public bool Nonmember { get; set; }

    public decimal RewardPoints { get; set; }

    public bool ConfirmedRso { get; set; }

    public DateOnly LastStatementDate { get; set; }

    public DateOnly? LastUpdatePasswordDate { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public string? ImportId { get; set; }

    public bool IsSystem { get; set; }

    public virtual ICollection<AppleWalletAuth> AppleWalletAuths { get; } = new List<AppleWalletAuth>();

    public virtual ICollection<DiscountCodeUsage> DiscountCodeUsages { get; } = new List<DiscountCodeUsage>();

    public virtual ICollection<StaffLevelUser> StaffLevelUsers { get; } = new List<StaffLevelUser>();
}
