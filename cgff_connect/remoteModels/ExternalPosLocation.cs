using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ExternalPosLocation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? UserId { get; set; }

    public int? EntityId { get; set; }

    public int? AccountingGroupId { get; set; }

    public string Description { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public int? TaxAccountingGroupId { get; set; }

    public string TaxDescription { get; set; } = null!;

    public string TaxPrefix { get; set; } = null!;

    public int? TipAccountingGroupId { get; set; }

    public string TipDescription { get; set; } = null!;

    public string TipPrefix { get; set; } = null!;
}
