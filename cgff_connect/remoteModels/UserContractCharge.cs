using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserContractCharge
{
    public int Id { get; set; }

    public int? UserContractId { get; set; }

    public ulong? ChargeId { get; set; }

    public virtual Charge? Charge { get; set; }
}
