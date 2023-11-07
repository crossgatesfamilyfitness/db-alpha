using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TeeSheet
{
    public int Id { get; set; }

    public int TeeSheetTemplateId { get; set; }

    public string TeeSheetTemplateName { get; set; } = null!;

    /// <summary>
    /// comma separated list
    /// </summary>
    public string DaysOfWeek { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int ResourceId { get; set; }
}
