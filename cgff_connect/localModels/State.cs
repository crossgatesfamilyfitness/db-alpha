using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class State
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string? ParentId { get; set; }

    public string? Type { get; set; }

    public int? CountryId { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual Country? Country { get; set; }
}
