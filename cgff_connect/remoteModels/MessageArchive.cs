using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class MessageArchive
{
    public long Id { get; set; }

    public int? MailId { get; set; }

    public int? UserCreateId { get; set; }

    public int? UserFromId { get; set; }

    public string UserFromContact { get; set; } = null!;

    public int? UserToId { get; set; }

    public string UserToContact { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTime SentDate { get; set; }

    public DateTime? ChangeStatusDate { get; set; }

    public string Type { get; set; } = null!;

    public sbyte Status { get; set; }

    public sbyte IsDeleted { get; set; }

    public string StatusMessage { get; set; } = null!;

    public long UniqueId { get; set; }

    public short NumSmsSegments { get; set; }

    public DateTime UtcTimestamp { get; set; }
}
