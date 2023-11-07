using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ServiceFeeRule
{
    public int Id { get; set; }

    public int? ServiceTypeId { get; set; }

    public bool? UseFeeCategoryDefaults { get; set; }

    public bool? UseCommissionCategoryDefaults { get; set; }

    public bool SeparateFeeByLocation { get; set; }

    public bool SeparateFeeByParticipants { get; set; }

    public int SeparateFeeMaxParticipants { get; set; }

    public bool SeparateFeeGuest { get; set; }

    public bool SeparateFeeEmployee { get; set; }

    public bool SeparateFeeByStaffLevel { get; set; }

    public string CommissionBasis { get; set; } = null!;

    public bool SeparateCommissionByLocation { get; set; }

    public bool SeparateCommissionByParticipants { get; set; }

    public bool SeparateCommissionByStaffLevel { get; set; }

    public bool LimitCommissionByRevenue { get; set; }

    public string WhoPaysDiscount { get; set; } = null!;

    public virtual ServiceType? ServiceType { get; set; }
}
