using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ContactUsEmailConfig
{
    public int Id { get; set; }

    public int LocationId { get; set; }

    public string ToEmail { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }
}
