using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ReleaseNote
{
    public int Id { get; set; }

    public int PostId { get; set; }

    public string Text { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string Link { get; set; } = null!;
}
