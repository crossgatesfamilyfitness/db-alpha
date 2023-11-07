using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Errorlog
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Comment { get; set; }

    public string? TableName { get; set; }

    public string? SqlStatement { get; set; }

    public DateTime TimeStamp { get; set; }
}
