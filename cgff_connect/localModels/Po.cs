using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Po
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Location { get; set; }

    public string? Description { get; set; }

    public string? Caption { get; set; }

    public long? AddressId { get; set; }

    public string? State { get; set; }

    public string Country { get; set; } = null!;

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public bool? Status { get; set; }

    public int EntityId { get; set; }

    public bool? KitchenReceiptGrouping { get; set; }

    public bool MultiplePrintjobs { get; set; }

    public bool EnableTips { get; set; }

    public int TipsAccountingGroupId { get; set; }

    public bool? EnablePin { get; set; }

    public string EmvTerminalId { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public bool? PrintMerchantCopyWithEmail { get; set; }

    public int ShopShortcutMenuId { get; set; }

    public virtual Address? AddressNavigation { get; set; }
}
