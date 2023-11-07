using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopItemManufacturerStore
{
    public uint Id { get; set; }

    public uint? ShopItemManufacturerId { get; set; }

    public uint? ShopStoreId { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string PaymentTerms { get; set; } = null!;

    public string CreditLimit { get; set; } = null!;

    public byte Active { get; set; }
}
