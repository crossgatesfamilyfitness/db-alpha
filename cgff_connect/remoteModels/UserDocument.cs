using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserDocument
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string File { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public long FileSize { get; set; }

    public string MimeType { get; set; } = null!;

    public bool FileType { get; set; }

    public bool LiabilityWaiver { get; set; }

    public int? NoteId { get; set; }

    public int DocumentType { get; set; }

    public bool? IsUploaded { get; set; }

    public string? IpAddress { get; set; }
}
