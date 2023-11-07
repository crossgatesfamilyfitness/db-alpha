using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class GroupDepartment
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? DepartmentId { get; set; }
}
