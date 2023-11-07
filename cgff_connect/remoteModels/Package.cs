using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Package
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NameMobile { get; set; }

    public string? DescriptionMobile { get; set; }

    public uint AddedBy { get; set; }

    public int ComponentId { get; set; }

    public decimal Price { get; set; }

    public decimal NonmemberPrice { get; set; }

    public decimal Count { get; set; }

    public sbyte Status { get; set; }

    public bool CanExpire { get; set; }

    public string? ExpirationType { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public int ExpirationDurationCount { get; set; }

    public string? ExpirationDurationType { get; set; }

    public string? Description { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public sbyte MaximumUses { get; set; }

    public string MaximumUsesPeriod { get; set; } = null!;

    public bool PrimaryActivityPackage { get; set; }

    public int? AccountingGroupId { get; set; }

    public string PackageType { get; set; } = null!;

    public bool AnyStaff { get; set; }

    public bool AutoRenew { get; set; }

    public string? AutoRenewType { get; set; }

    public bool AutoRenewUnlimited { get; set; }

    public int AutoRenewCount { get; set; }

    public int SendReminderDays { get; set; }

    public string StaffLevel { get; set; } = null!;

    public string PriceType { get; set; } = null!;

    public int LessonType { get; set; }

    public string PlayerOnCourt { get; set; } = null!;

    public string ShareWithLinked { get; set; } = null!;

    /// <summary>
    /// 1 - yes, 0 - no
    /// </summary>
    public bool DefaultShareSetting { get; set; }

    public bool? DayOfWeek { get; set; }

    public bool NotificationExpired { get; set; }

    public bool NotificationRenewal { get; set; }

    public bool HasPaymentPlan { get; set; }

    public int PaymentPlan { get; set; }

    public bool ProfileSaleEnabled { get; set; }

    public bool? MobileSaleEnabled { get; set; }

    public bool PosSaleEnabled { get; set; }

    public int? ContractTermsId { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public bool MobileHasPaymentPlan { get; set; }

    public int MobilePaymentPlan { get; set; }

    public bool? MobileRegRequirePayment { get; set; }

    public bool SessionCarryOverEnabled { get; set; }

    public bool AutoRenewInterval { get; set; }

    public int RenewalInterval { get; set; }

    public string RenewalIntervalPeriod { get; set; } = null!;
}
