using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserAdvancedRating
{
    public int Id { get; set; }

    public int? DepartmentId { get; set; }

    public int? UserId { get; set; }

    public int? AdvancedRatingId { get; set; }

    public sbyte IsActive { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? CompletionDate { get; set; }
}
