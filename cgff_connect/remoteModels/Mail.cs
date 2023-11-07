using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class Mail
{
    public int Id { get; set; }

    public uint UserId { get; set; }

    public string Type { get; set; } = null!;

    public string Uid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Flag { get; set; } = null!;

    public bool Removed { get; set; }

    public DateTime LastUpdate { get; set; }

    public string Subject { get; set; } = null!;

    /// <summary>
    /// short body for push notification lock screen
    /// </summary>
    public string? ShortBody { get; set; }

    public DateTime Date { get; set; }

    public string From { get; set; } = null!;

    public uint FromUser { get; set; }

    public string? To { get; set; }

    public string HasAttachment { get; set; } = null!;

    public int Size { get; set; }

    public string Headers { get; set; } = null!;

    public string FullMessage { get; set; } = null!;

    public string Body { get; set; } = null!;

    public sbyte SendStatus { get; set; }

    public DateTime ScheduledTime { get; set; }

    public string MessageType { get; set; } = null!;

    public int NotificationType { get; set; }

    public long ScheduleId { get; set; }

    public int EntityId { get; set; }

    public bool MailToPrimary { get; set; }
}
