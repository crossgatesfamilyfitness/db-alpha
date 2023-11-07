using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Note
{
    public int Id { get; set; }

    public uint? UserId { get; set; }

    public DateOnly Date { get; set; }

    public DateTime Created { get; set; }

    public uint CreatedBy { get; set; }

    public string Note1 { get; set; } = null!;

    public int NoteSubjectId { get; set; }

    public string NoteSubjectText { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int EntityId { get; set; }

    public bool Private { get; set; }

    public int EventId { get; set; }

    public int ScheduleId { get; set; }

    public int ResourceId { get; set; }

    public bool Dismissed { get; set; }

    public uint? DismissedBy { get; set; }

    public DateTime Edited { get; set; }

    public int EditedBy { get; set; }

    public bool ShowAtCheckin { get; set; }

    public DateOnly? ExpirationDateOnCheckin { get; set; }
}
