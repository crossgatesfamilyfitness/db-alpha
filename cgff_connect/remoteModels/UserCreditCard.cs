using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserCreditCard
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; } = null!;

    public int? CcType { get; set; }

    public string CcNumber { get; set; } = null!;

    public string Fcc { get; set; } = null!;

    public string CcName { get; set; } = null!;

    public DateOnly CcDate { get; set; }

    public bool BillAddrType { get; set; }

    public string BillStreetAddress { get; set; } = null!;

    public string BillStreetAddress2 { get; set; } = null!;

    public string BillCity { get; set; } = null!;

    public string BillState { get; set; } = null!;

    public string BillCountryCode { get; set; } = null!;

    public string BillZip { get; set; } = null!;

    public string BillPhone { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public DateTime CreatedDate { get; set; }

    public uint ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public string Shift4TokenSerialNumber { get; set; } = null!;

    public int AvailableOnPos { get; set; }

    public string PaymentProcessorUniqueId { get; set; } = null!;

    public string PaymentProcessorCofId { get; set; } = null!;

    public string? IsSyncedToUpdater { get; set; }

    public uint ModifiedByIntranet { get; set; }
}
