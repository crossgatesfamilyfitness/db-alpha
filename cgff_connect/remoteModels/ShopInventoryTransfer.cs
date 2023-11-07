using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopInventoryTransfer
{
    public uint Id { get; set; }

    public DateOnly TransferDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public int OriginStoreId { get; set; }

    public int DestinationStoreId { get; set; }

    public int TransferredBy { get; set; }

    public int? ReceivedBy { get; set; }

    public sbyte TotalItem { get; set; }

    public decimal TotalQuantity { get; set; }

    public decimal TotalCost { get; set; }

    public sbyte Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public string? TransferComment { get; set; }

    public string? ReceiverComment { get; set; }
}
