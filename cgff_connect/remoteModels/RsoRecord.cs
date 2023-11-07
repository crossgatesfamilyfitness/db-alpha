using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class RsoRecord
{
    public int Id { get; set; }

    public int RsoCheckId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? DateReviewed { get; set; }

    public int? ReviewerId { get; set; }

    public string RsoId { get; set; } = null!;

    public string RsoName { get; set; } = null!;

    public string RsoUrl { get; set; } = null!;

    public string RsoImage { get; set; } = null!;

    public string RsoStatus { get; set; } = null!;

    public string RsoBirthDate { get; set; } = null!;

    public string RsoRace { get; set; } = null!;

    public string RsoSex { get; set; } = null!;

    public string RsoHairColor { get; set; } = null!;

    public string RsoDesignation { get; set; } = null!;

    public string RsoStreet { get; set; } = null!;

    public string RsoState { get; set; } = null!;

    public string RsoZip { get; set; } = null!;

    public string RsoScars { get; set; } = null!;

    public string RsoAliases { get; set; } = null!;

    public string RsoWeight { get; set; } = null!;

    public string Source { get; set; } = null!;
}
