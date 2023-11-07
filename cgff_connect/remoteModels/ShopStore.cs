using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ShopStore
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int LocationId { get; set; }

    public long? BillingAddressId { get; set; }

    public long? ShippingAddressId { get; set; }

    public string BillingStreetAddress { get; set; } = null!;

    public string BillingStreetAddress2 { get; set; } = null!;

    public string BillingCity { get; set; } = null!;

    public string BillingState { get; set; } = null!;

    public string BillingZip { get; set; } = null!;

    public string ShippingStreetAddress { get; set; } = null!;

    public string ShippingStreetAddress2 { get; set; } = null!;

    public string ShippingCity { get; set; } = null!;

    public string ShippingState { get; set; } = null!;

    public string ShippingZip { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public bool Active { get; set; }

    public int AccountingGroupId { get; set; }

    public virtual Address? BillingAddress { get; set; }

    public virtual Address? ShippingAddress { get; set; }
}
