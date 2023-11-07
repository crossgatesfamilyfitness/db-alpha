using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ChargeDeposit
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    public float Amount { get; set; }

    public int ChargeId { get; set; }

    public DateTime DateCreated { get; set; }

    public int AccGroupId { get; set; }

    public int EntityId { get; set; }

    public string Description { get; set; } = null!;

    public int DepositChargeId { get; set; }

    public int DepositCreditPaymentId { get; set; }

    public sbyte IsRemoved { get; set; }
}
