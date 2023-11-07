using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class ContractTerm
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string? TermsConditions { get; set; }

    public string? WaiverRelease { get; set; }

    public string? EftAuth { get; set; }

    public bool IsActive { get; set; }

    public bool IsDefault { get; set; }

    public virtual ICollection<Contract> Contracts { get; } = new List<Contract>();

    public virtual ICollection<Group> Groups { get; } = new List<Group>();
}
