using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ContractContainerTerm
{
    public int Id { get; set; }

    public int? ContractContainerId { get; set; }

    public int? ContractTermsId { get; set; }

    public string? Category { get; set; }

    public bool InsertPageBreak { get; set; }

    public short TermsOrder { get; set; }

    public virtual ContractContainer? ContractContainer { get; set; }

    public virtual ContractTerm? ContractTerms { get; set; }
}
