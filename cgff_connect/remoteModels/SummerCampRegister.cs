using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SummerCampRegister
{
    public uint UserId { get; set; }

    public ulong ScheduleId { get; set; }

    public int LessonType { get; set; }
}
