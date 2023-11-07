using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserPackage
{
    public uint Id { get; set; }

    public uint PackageId { get; set; }

    public uint UserId { get; set; }

    public uint StaffId { get; set; }

    public sbyte Type { get; set; }

    public string Name { get; set; } = null!;

    public uint AddedBy { get; set; }

    public DateOnly AddedDate { get; set; }

    public DateOnly ActivatedDate { get; set; }

    public DateTime AddedTime { get; set; }

    public int ComponentId { get; set; }

    public decimal Price { get; set; }

    public decimal PriceInitial { get; set; }

    public decimal PricePerSession { get; set; }

    public decimal Count { get; set; }

    public decimal CountInitial { get; set; }

    public sbyte Status { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public bool CanExpire { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public int ExpirationDurationCount { get; set; }

    public string? ExpirationDurationType { get; set; }

    public DateOnly UsedDate { get; set; }

    public DateOnly RecognizedDate { get; set; }

    public string? Description { get; set; }

    public uint PrimaryActivityId { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public string PriceType { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public int LessonType { get; set; }

    public int AccGroupId { get; set; }

    public ushort PlayerOnCourt { get; set; }

    public int EntityId { get; set; }

    public int? RateId { get; set; }

    public bool AutoRenew { get; set; }

    public string? AutoRenewType { get; set; }

    public bool AutoRenewUnlimited { get; set; }

    public int AutoRenewCount { get; set; }

    public bool AutoRenewComplete { get; set; }

    public int AutoRenewParentPackageId { get; set; }

    public decimal AutoRenewPrice { get; set; }

    public bool ReminderExpirationSend { get; set; }

    /// <summary>
    /// 1 - yes, 0 - no
    /// </summary>
    public bool DefaultShareSetting { get; set; }

    public string SpecificStaffLevel { get; set; } = null!;

    public string? SpecificStaffList { get; set; }

    public uint SoldBy { get; set; }

    public bool NotificationExpired { get; set; }

    public bool NotificationRenewal { get; set; }

    public int SendReminderDays { get; set; }

    public bool AnyStaff { get; set; }

    public bool? DayOfWeek { get; set; }

    public sbyte MaximumUses { get; set; }

    public string MaximumUsesPeriod { get; set; } = null!;

    public int? ContractTermsId { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public bool SessionCarryOverEnabled { get; set; }
}
