using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Club
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Abbr { get; set; }

    public string Description { get; set; } = null!;

    public string? Prefix { get; set; }

    public decimal Tax { get; set; }

    public decimal? GuestFee { get; set; }

    public string GuestFeeType { get; set; } = null!;

    public string CustomReceiptText { get; set; } = null!;

    public int CourtGridStep { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Address { get; set; }

    public string? MailAddress { get; set; }

    public string? City { get; set; }

    public string? MailCity { get; set; }

    public string? State { get; set; }

    public string Country { get; set; } = null!;

    public string? MailState { get; set; }

    public string MailCountry { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string MailZip { get; set; } = null!;

    public DateOnly Eft { get; set; }

    public int GracePeriod { get; set; }

    public int CancellationPeriod { get; set; }

    public string DueDates { get; set; } = null!;

    public int? ReceiptCopies { get; set; }

    public string Emails { get; set; } = null!;

    public bool? MailToPrimary { get; set; }

    public string TimeZone { get; set; } = null!;

    public string Copyright { get; set; } = null!;

    public decimal FreeReservationPeriod { get; set; }

    public string Invoice { get; set; } = null!;

    public int BatchNo { get; set; }

    public string? LastLetter { get; set; }

    public string GuestFeeGroups { get; set; } = null!;

    public string GuestFeeStatuses { get; set; } = null!;

    public string Payroll { get; set; } = null!;

    public int PayrollDeadline { get; set; }

    public int ApprovalPeriod { get; set; }

    public int ParkDistrictGroup { get; set; }

    public bool VerifyCc { get; set; }

    public int GuestVisitsAllowance { get; set; }

    public string AccountingType { get; set; } = null!;

    public string EventGuestFee { get; set; } = null!;

    public bool? SellSeasonTime { get; set; }

    public bool PrimaryActivityPackage { get; set; }

    public uint GuestUsageReport { get; set; }

    public int DefaultComponentId { get; set; }

    public decimal MembershipPackDiscount { get; set; }

    public string BigLogo { get; set; } = null!;

    public string SmallLogo { get; set; } = null!;

    public string SplashScreenImg { get; set; } = null!;

    public string GuestFeeParams { get; set; } = null!;

    public float RefererCredit { get; set; }

    public bool Lesson45minute { get; set; }

    public bool? EmailVerification { get; set; }

    public string GroupEventNonmemberPriceType { get; set; } = null!;

    public string BillingRates { get; set; } = null!;

    public TimeOnly SmsTimeFrom { get; set; }

    public bool SepLessonCourtFee { get; set; }

    public sbyte SeparateChashCheck { get; set; }

    public sbyte CloseShiftAuto { get; set; }

    public TimeOnly CloseShiftAfter { get; set; }

    public bool ShowSubAccGroupsInQb { get; set; }

    public bool? BillGuestFeeType { get; set; }

    public string AccountingSystem { get; set; } = null!;

    public string Mas90Version { get; set; } = null!;

    public string? ExpPackageRecognition { get; set; }

    public sbyte CheckinTakePhoto { get; set; }

    public string ExternalPosParams { get; set; } = null!;

    public string? DataCleansingParams { get; set; }

    public string? WebApiParams { get; set; }

    public string DefaultEntitiesForStaff { get; set; } = null!;

    public string? RestapiParams { get; set; }

    public string PncAchParams { get; set; } = null!;

    public string TempGlobaladminPass { get; set; } = null!;

    public string? GoogleAnalyticsCode { get; set; }

    public int? GuestFeeAccountingGroup { get; set; }

    public string? GuestFeeDescription { get; set; }

    public string? GuestPassAutomaticSettings { get; set; }

    public string BalanceDate { get; set; } = null!;

    public sbyte BalanceDateCustomDay { get; set; }

    public string BalanceDateCustomMonth { get; set; } = null!;

    public bool? DepositsEnabled { get; set; }

    public string? DepositsLiabilityGroup { get; set; }

    public DateTime CheckinResetDatetime { get; set; }

    public string? EmailReceiptSubjectLine { get; set; }

    public int EmailReceiptTemplate { get; set; }

    /// <summary>
    /// Club Collection Settings
    /// </summary>
    public string? CollectionsSettings { get; set; }

    public string? PrintParams { get; set; }

    public bool? IncludePendingChargesInPastDue { get; set; }

    public string MemberStatementType { get; set; } = null!;

    public string IctType { get; set; } = null!;

    public bool? AllowCreditIct { get; set; }

    public string Address2 { get; set; } = null!;

    public string MailAddress2 { get; set; } = null!;

    public string EftPaymentOption { get; set; } = null!;

    public string MonthlyContractDate { get; set; } = null!;

    public string GroupRevenueMapping { get; set; } = null!;

    public bool IncludeCreditPaymentsOnStatement { get; set; }

    /// <summary>
    /// Shift4 Local UTG url
    /// </summary>
    public string? Shift4LocalUtgUrl { get; set; }

    /// <summary>
    /// Online Registration Settings
    /// </summary>
    public string? OnlineRegSettings { get; set; }

    public bool? SecondarySignature { get; set; }

    public bool StaffMemberSignature { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
