using System;
using System.Collections.Generic;

namespace cgff_connect.remoteModels;

public partial class UserApiMenuSetting
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public bool? Locations { get; set; }

    public bool? LocationHours { get; set; }

    public bool? Login { get; set; }

    public bool? MembershipCard { get; set; }

    public bool? Programs { get; set; }

    public bool? TryUs { get; set; }

    public bool? GroupEx { get; set; }

    public bool? Favorites { get; set; }

    public bool? Reservations { get; set; }

    public bool PayBill { get; set; }

    public bool Packages { get; set; }

    public bool Sso { get; set; }

    public bool Waitlist { get; set; }

    public bool CapacityCounter { get; set; }

    public bool RegisterNow { get; set; }

    public bool GoogleApplePay { get; set; }

    public bool ResourceWaitlist { get; set; }

    public bool BecomeMember { get; set; }

    public bool ChildcareReservation { get; set; }

    public bool AppointmentRequests { get; set; }
}
