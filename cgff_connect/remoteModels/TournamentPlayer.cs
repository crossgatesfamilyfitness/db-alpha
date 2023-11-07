using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class TournamentPlayer
{
    public int Id { get; set; }

    public int TournamentId { get; set; }

    public uint? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? UstaNumber { get; set; }
}
