using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopVendor
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string StreetAddress { get; set; } = null!;

    public string StreetAddress2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long? AddressId { get; set; }

    public byte Status { get; set; }

    public DateTime TimeCreated { get; set; }

    public byte AllStores { get; set; }

    public virtual Address? Address { get; set; }
}
