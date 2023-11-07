using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ContractTermsBlock
{
    public int Id { get; set; }

    public int? ContractTermsId { get; set; }

    public string Tab { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Text { get; set; } = null!;

    public bool NeedSignature { get; set; }

    public bool AddPageBreak { get; set; }

    public bool ShowTotals { get; set; }

    public virtual ContractTerm? ContractTerms { get; set; }
}
