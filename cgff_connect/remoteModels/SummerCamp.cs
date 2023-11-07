using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class SummerCamp
{
    public int Id { get; set; }

    public uint EventId { get; set; }

    public string? Location { get; set; }

    public DateOnly? RegistrationDeadline { get; set; }
}
