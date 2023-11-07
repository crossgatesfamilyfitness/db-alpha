using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ResourceWaitlistParticipant
{
    /// <summary>
    /// resource waitlist id
    /// </summary>
    public uint ResourceWaitlistId { get; set; }

    /// <summary>
    /// participant id
    /// </summary>
    public uint ParticipantId { get; set; }

    /// <summary>
    /// order of participants in waitlist
    /// </summary>
    public uint SortOrder { get; set; }
}
