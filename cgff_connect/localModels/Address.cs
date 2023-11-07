using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Address
{
    public long Id { get; set; }

    public int? StateId { get; set; }

    public int CountryId { get; set; }

    public string? Street { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? LastTrack { get; set; }

    public int ModifiedBy { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<Check> Checks { get; } = new List<Check>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Po> Pos { get; } = new List<Po>();

    public virtual ICollection<ShopItemManufacturer> ShopItemManufacturers { get; } = new List<ShopItemManufacturer>();

    public virtual ICollection<ShopStore> ShopStoreBillingAddresses { get; } = new List<ShopStore>();

    public virtual ICollection<ShopStore> ShopStoreShippingAddresses { get; } = new List<ShopStore>();

    public virtual ICollection<ShopVendor> ShopVendors { get; } = new List<ShopVendor>();

    public virtual State? State { get; set; }
}
