using System;
using System.Collections.Generic;

namespace cgff_connect.localModels;

public partial class Check
{
    public int Id { get; set; }

    public decimal Amount { get; set; }

    public string? CheckNumber { get; set; }

    public DateOnly? CheckDate { get; set; }

    public long? AddressId { get; set; }

    public string? DriversLicense { get; set; }

    public string? PhoneNumber { get; set; }

    public string? StreetAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public virtual Address? Address { get; set; }
}
