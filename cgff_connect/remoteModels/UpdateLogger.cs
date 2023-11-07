using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UpdateLogger
{
    public long Id { get; set; }

    public int UpdatedId { get; set; }

    public string UpdatedObject { get; set; } = null!;

    public string InvolvedService { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    /// <summary>
    /// 0 - waiting, 1 - updated
    /// </summary>
    public bool UpdatedStatus { get; set; }
}
