using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class PackageLessonType
{
    public uint PackageId { get; set; }

    public int LessonType { get; set; }

    public int ComponentId { get; set; }
}
