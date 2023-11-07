using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Event
{
    public uint Id { get; set; }

    public int? ComponentId { get; set; }

    public int SeasonId { get; set; }

    public int AccGroupId { get; set; }

    public int AccLiabilityGroupId { get; set; }

    public uint? OwnerId { get; set; }

    public int? ResourceId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? EventTypeId { get; set; }

    public decimal? Fee { get; set; }

    public float? GuestFee { get; set; }

    public decimal? PremiumFee { get; set; }

    public float? GuestPremiumFee { get; set; }

    public float EarlyFee { get; set; }

    public float GuestEarlyFee { get; set; }

    public decimal RegistrationFee { get; set; }

    public decimal RegistrationGuestFee { get; set; }

    public int RegistrationFeeAccGroup { get; set; }

    public bool? FeeType { get; set; }

    public decimal? Comission { get; set; }

    public string ComissionFormula { get; set; } = null!;

    public decimal? ProFee { get; set; }

    public int? PersonsMaximum { get; set; }

    public bool? IsPersonsMaximum { get; set; }

    public uint? OrganizerId { get; set; }

    public string? Comments { get; set; }

    public bool? ShowOnGrid { get; set; }

    public sbyte? MembersOnly { get; set; }

    public string Location { get; set; } = null!;

    public string Params { get; set; } = null!;

    public bool AllMembership { get; set; }

    public bool AllRating { get; set; }

    public int ParentId { get; set; }

    public int GroupId { get; set; }

    public string? ParentName { get; set; }

    public string? ProgramName { get; set; }

    public int Order { get; set; }

    public bool SplitToHours { get; set; }

    public bool? SelectPro { get; set; }

    public bool Archived { get; set; }

    public bool OnlineReg { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string LastTrack { get; set; } = null!;

    public bool SuspendOnlineReg { get; set; }

    public DateTime SuspendOnlineRegDate { get; set; }

    public DateTime DateOpenAsOf { get; set; }

    public DateTime DateDisplayAsOf { get; set; }

    public int AutobillMembershipId { get; set; }

    public float? TotalGuestFee { get; set; }

    public decimal? PerTimeGuestFee { get; set; }

    public float TotalEarlyGuestFee { get; set; }

    public float MaxPayrollPercent { get; set; }

    public string? Level { get; set; }

    public string? Age { get; set; }

    public short AgeTo { get; set; }

    public int? InstructorId { get; set; }

    public string LeagueId { get; set; } = null!;

    public bool Tbd { get; set; }

    public string ClassNumber { get; set; } = null!;

    public int? LinkedSessionId { get; set; }

    public int? LinkedEventId { get; set; }

    public string? LinkedType { get; set; }

    public DateOnly? LinkedDate { get; set; }

    public int EntityId { get; set; }

    public string? AllowedEntities { get; set; }

    public decimal? AgeRestrictionFrom { get; set; }

    public decimal? AgeRestrictionTo { get; set; }

    public string IconName { get; set; } = null!;

    public string IconFileName { get; set; } = null!;

    public string IconType { get; set; } = null!;

    /// <summary>
    /// 0 - hidden, 1 - visible
    /// </summary>
    public bool? ApiScheduleVisible { get; set; }

    public int PriorityRegistrationStatus { get; set; }

    public DateTime? PriorityRegistrationOpenDate { get; set; }

    public DateTime? PriorityRegistrationCloseDate { get; set; }

    public int PriorityRegistrationClasses { get; set; }

    public int OnlineRegOpenValue { get; set; }

    public string OnlineRegOpenPeriod { get; set; } = null!;

    public int OnlineRegCloseValue { get; set; }

    public string OnlineRegClosePeriod { get; set; } = null!;

    public int Capacity { get; set; }

    public string LateUnregFeeType { get; set; } = null!;

    public decimal LateUnregFeeAmount { get; set; }

    public int LateUnregFeeAccGroup { get; set; }

    public int LateUnregWindowValue { get; set; }

    public string LateUnregWindowPeriod { get; set; } = null!;

    public bool CanUnregOnline { get; set; }

    public bool NoShowFeeAllowed { get; set; }

    public decimal NoShowFeeAmount { get; set; }

    public int NoShowFeeAccGroup { get; set; }

    public int? ServiceId { get; set; }

    public int? WaitlistMaximum { get; set; }

    public int GuestFeeAccountingGroupId { get; set; }

    public bool DeferredRevenue { get; set; }

    public short LockWaitlistValue { get; set; }

    public string LockWaitlistPeriod { get; set; } = null!;

    public string AddPlayerWaitlist { get; set; } = null!;

    public int ConfirmationValue { get; set; }

    public string ConfirmationPeriod { get; set; } = null!;

    public uint ModifiedByIntranet { get; set; }

    public virtual ICollection<EventCustomFee> EventCustomFees { get; } = new List<EventCustomFee>();

    public virtual ICollection<ScheduleServiceCommission> ScheduleServiceCommissions { get; } = new List<ScheduleServiceCommission>();

    public virtual Service? Service { get; set; }
}
