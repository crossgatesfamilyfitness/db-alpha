using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserImportBulk
{
    public int Id { get; set; }

    public uint ImportId { get; set; }

    public string ImportType { get; set; } = null!;

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string? LastTrack { get; set; }

    public uint ModifiedByIntranet { get; set; }

    public virtual ICollection<UserImportBulkItem> UserImportBulkItems { get; } = new List<UserImportBulkItem>();
}
