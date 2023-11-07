using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class NoteSubject
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool? Status { get; set; }
}
