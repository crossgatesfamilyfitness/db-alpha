using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupEntityPrice
{
    public int Id { get; set; }

    public int? GroupEntityBillingId { get; set; }

    public int? GroupId { get; set; }

    public int? EntityId { get; set; }

    public decimal BaseFee { get; set; }

    public decimal EnrollmentFee { get; set; }

    public string FamilyRole { get; set; } = null!;

    public string? DependentPriceType { get; set; }

    public decimal StartAge { get; set; }

    public decimal EndAge { get; set; }

    public short Order { get; set; }
}
