using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserArchive
{
    public ulong Id { get; set; }

    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string ContractNum { get; set; } = null!;

    public DateOnly Joined { get; set; }

    public DateOnly ArchiveDate { get; set; }

    public int ArchivedBy { get; set; }

    public string Data { get; set; } = null!;

    public string? ByParentId { get; set; }

    public string? ByPrimaryId { get; set; }

    public string? Events { get; set; }
}
