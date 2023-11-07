using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class ImportAccgroupentity
{
    public uint InternalId { get; set; }

    /// <summary>
    /// Must match existing entity name
    /// </summary>
    public string EntityName { get; set; } = null!;

    /// <summary>
    /// accounting group name
    /// </summary>
    public string? AccGroupName { get; set; }

    /// <summary>
    /// online_name
    /// </summary>
    public string? OnlineName { get; set; }

    /// <summary>
    /// prefix
    /// </summary>
    public string? Prefix { get; set; }

    /// <summary>
    /// gl_code
    /// </summary>
    public string? GlCode { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? CcRetailer { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? Default { get; set; }

    /// <summary>
    /// i do not know what this field is
    /// </summary>
    public string? DefaultLocation { get; set; }

    /// <summary>
    /// enum(&apos;Yes&apos;,&apos;No&apos;)
    /// </summary>
    public string? OnlineIsVisible { get; set; }

    /// <summary>
    /// 3 digit time zone
    /// </summary>
    public string? TimeZone { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// fax
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// address2
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// state
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// zip
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// Mailing address2
    /// </summary>
    public string? MailAddress { get; set; }

    /// <summary>
    /// Mailing address2
    /// </summary>
    public string? MailAddress2 { get; set; }

    /// <summary>
    /// Mailing City
    /// </summary>
    public string? MailCity { get; set; }

    /// <summary>
    /// Mailing State
    /// </summary>
    public string? MailState { get; set; }

    /// <summary>
    /// Mailing Zip
    /// </summary>
    public string? MailZip { get; set; }

    /// <summary>
    /// description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Longitude
    /// </summary>
    public decimal? Longitude { get; set; }

    /// <summary>
    /// Latitude
    /// </summary>
    public decimal? Latitude { get; set; }

    /// <summary>
    /// csv line number that corresponds to this row
    /// </summary>
    public int CsvLineNo { get; set; }

    /// <summary>
    /// unique id from the row inserted to ca production db
    /// </summary>
    public int? CaId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }
}
