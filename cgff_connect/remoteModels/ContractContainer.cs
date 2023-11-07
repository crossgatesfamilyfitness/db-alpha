using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ContractContainer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDefault { get; set; }

    public string FrontPageTermsTitle { get; set; } = null!;

    public string? FrontPageTerms { get; set; }

    public virtual ICollection<ContractContainerTerm> ContractContainerTerms { get; } = new List<ContractContainerTerm>();
}
