using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopItemManufacturer
{
    public int Id { get; set; }

    public int ComponentId { get; set; }

    public uint? VendorId { get; set; }

    public sbyte? ParentId { get; set; }

    public string? Title { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long? AddressId { get; set; }

    public string StreetAddress { get; set; } = null!;

    public string StreetAddress2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public DateTime TimeCreated { get; set; }

    public byte AllStores { get; set; }

    public bool? Status { get; set; }

    public DateTime UtcTimestamp { get; set; }

    public virtual Address? Address { get; set; }
}
