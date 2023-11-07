using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Country
{
    public int Id { get; set; }

    public string Alpha2 { get; set; } = null!;

    public string Alpha3 { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Numeric { get; set; }

    public string? ShortName { get; set; }

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<State> States { get; } = new List<State>();
}
